using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.General;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.General
{
    public sealed class TagModel: EntityModel, ITagModel
    {
        public string Title { get; set; }
        
        [IgnoreProperty]
        public string TagGroupId
        {
            get => PartitionKey;
            set => PartitionKey = value;
        }
    }
}