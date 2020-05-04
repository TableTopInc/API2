using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Base
{
    public abstract class OneToManyLink: ObjectBase, IOneToManyLink
    {
        [IgnoreProperty]
        public string OneId
        {
            get => PartitionKey;
            set => PartitionKey = value;
        }

        public string ManyId { get; set; }
    }
}