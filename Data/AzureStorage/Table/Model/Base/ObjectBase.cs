using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Base
{
    public abstract class ObjectBase: TableEntity, IObjectBase
    {
        protected const string DefaultPartition = "";
        
        [IgnoreProperty]
        public string Id
        {
            get => RowKey;
            set => RowKey = value;
        }

        protected ObjectBase()
        {
            PartitionKey = DefaultPartition;
        }
    }
}