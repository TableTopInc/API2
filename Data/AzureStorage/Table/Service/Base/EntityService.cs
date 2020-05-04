using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Service.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Service.Base
{
    public abstract class EntityService<T> : IEntityService<T>
        where T : ObjectBase, new()
    {
        private const int BatchMaxSize = 100;
        private const int QueryMaxParams = 15;
        private const int QueryMaxParamsForSinglePartition = QueryMaxParams - 1;

        private const string PartitionKeyPropertyName = nameof(TableEntity.PartitionKey);
        private const string RowKeyPropertyName = nameof(TableEntity.RowKey);
        
        protected readonly CloudTable Table;
        protected readonly string EntitiesOwnerId;

        internal EntityService(CloudTable table, string entitiesOwnerId = ObjectBase.DefaultPartitionKey)
        {
            Table = table;
            EntitiesOwnerId = entitiesOwnerId;
        }

        #region public
        
        public async Task<IEnumerable<T>> SaveAsync(params T[] entities)
        {
            foreach (var entity in entities.Where(x => string.IsNullOrWhiteSpace(x.Id)))
            {
                entity.Id = ToRowKey(Guid.NewGuid());
            }
            
            await ExecuteBatchAsync(entities, TableOperation.InsertOrReplace);

            return entities;
        }

        public async Task DeleteByIdAsync(params string[] ids)
        {
            var keys = ids
                .Select(x => new KeyValuePair<string, string>(EntitiesOwnerId, x))
                .ToArray();

            await DeleteByKeysAsync(keys);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await GetByFilterAsync(string.Empty);
        }

        public async Task<IEnumerable<T>> GetByIdAsync(params string[] ids)
        {
            var keys = ids
                .Select(x => new KeyValuePair<string, string>(EntitiesOwnerId, x))
                .ToArray();

            return await GetByKeysAsync(keys);
        }

        #endregion
        
        #region protected
        
        protected static string ToRowKey(Guid id)
        {
            return id.ToString("N");
        }
        
        protected async Task ExecuteBatchAsync(IEnumerable<T> entities, Func<T, TableOperation> func)
        {
            var groups = entities
                .GroupBy(x => x.PartitionKey, (key, items) => items.ToList());
            
            var tasks = new List<Task>();
            foreach (var entityGroup in groups)
            {
                var chunks = Math.Ceiling((decimal)entityGroup.Count / BatchMaxSize);
                for (var i = 0; i < chunks; i++)
                {
                    var tableBatch = new TableBatchOperation();
                    foreach (var entity in entityGroup.Skip(BatchMaxSize * i).Take(BatchMaxSize))
                    {
                        tableBatch.Add(func(entity));
                    }
                    tasks.Add(Table.ExecuteBatchAsync(tableBatch));
                }
            }

            await Task.WhenAll(tasks);
        }

        protected async Task DeleteByKeysAsync(params KeyValuePair<string, string>[] keys)
        {
            var entities = await GetByKeysAsync(keys);

            await ExecuteBatchAsync(entities, TableOperation.Delete);
        }
        
        protected async Task<IEnumerable<T>> GetByKeysAsync(params KeyValuePair<string, string>[] keys)
        {
            var partitions = keys
                .GroupBy(x => x.Key, (key, values) => values.ToList());

            var tasks = new List<Task<IEnumerable<T>>>();
            foreach (var rowKeys in partitions)
            {
                var chunks = Math.Ceiling((decimal)rowKeys.Count / QueryMaxParamsForSinglePartition);
                for (var i = 0; i < chunks; i++)
                {
                    var chunkKeys = rowKeys
                        .Skip(QueryMaxParamsForSinglePartition * i)
                        .Take(QueryMaxParamsForSinglePartition)
                        .ToList();

                    var queryString = TableQuery.GenerateFilterCondition(
                        RowKeyPropertyName,
                        QueryComparisons.Equal,
                        chunkKeys.First().Value);
                    
                    queryString = chunkKeys
                        .Skip(1)
                        .Aggregate(queryString,
                            (currentFilter, newFilter) => TableQuery.CombineFilters(
                                currentFilter,
                                TableOperators.Or,
                                TableQuery.GenerateFilterCondition(
                                    RowKeyPropertyName,
                                    QueryComparisons.Equal,
                                    newFilter.Value)));

                    if (chunkKeys.Count > 1)
                    {
                        queryString = $"({queryString})";
                    }

                    queryString = TableQuery.CombineFilters(
                        queryString,
                        TableOperators.And,
                        TableQuery.GenerateFilterCondition(
                            PartitionKeyPropertyName,
                            QueryComparisons.Equal,
                            rowKeys.First().Key));
                    
                    tasks.Add(GetByFilterAsync(queryString));
                }
            }

            await Task.WhenAll(tasks);

            return tasks
                .SelectMany(x => x.Result);
        }
        
        protected async Task<IEnumerable<T>> GetByFilterAsync(string filter)
        {
            var query = new TableQuery<T>().Where(filter);
            var results = new List<T>();
            
            TableContinuationToken token = null;
            do
            {
                var segment = await Table.ExecuteQuerySegmentedAsync(query, token);
                token = segment.ContinuationToken;
                results.AddRange(segment.Results);
            }
            while (token != null);

            return results;
        }
        
        #endregion
    }
}