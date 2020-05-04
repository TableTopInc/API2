using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Link;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Link
{
    public class TagGroupToTagLink: OneToManyLink, ITagGroupToTagLink
    {
        [IgnoreProperty]
        public string TagGroupId
        {
            get => OneId;
            set => OneId = value;
        }
        
        [IgnoreProperty]
        public string TagId
        {
            get => ManyId;
            set => ManyId = value;
        }
    }
}