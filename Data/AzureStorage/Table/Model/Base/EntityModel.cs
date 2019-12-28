using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Base
{
    public abstract class EntityModel: TableEntity, IEntityModel
    {
        protected const string DefaultPartition = "";
        
        [IgnoreProperty]
        public string Id
        {
            get => RowKey;
            set => RowKey = value;
        }

        protected EntityModel()
        {
            PartitionKey = DefaultPartition;
        }
    }
}