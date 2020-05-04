using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Service.Base
{
    public abstract class LinkedEntityService<T>: EntityService<T>
        where T : ObjectBase, new()

    {
        protected readonly CloudTable LinkTable;
        
        protected LinkedEntityService(CloudTable table, CloudTable linkTable, string entitiesOwnerId = ObjectBase.DefaultPartitionKey)
            : base(table, entitiesOwnerId)
        {
            LinkTable = linkTable;
        }
    }
}