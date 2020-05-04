using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Base
{
    public abstract class ObjectBase: TableEntity, IObjectBase
    {
        internal const string DefaultPartitionKey = "__shared";
        
        [IgnoreProperty]
        public string Id
        {
            get => RowKey;
            set => RowKey = value;
        }

        public ObjectBase()
        {
            PartitionKey = DefaultPartitionKey;
        }
    }
}