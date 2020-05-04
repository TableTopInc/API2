using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Link;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Link
{
    public class TagToGameLink: OneToManyLink, ITagToGameLink
    {
        [IgnoreProperty]
        public string TagId
        {
            get => OneId;
            set => OneId = value;
        }
        
        [IgnoreProperty]
        public string GameId
        {
            get => ManyId;
            set => ManyId = value;
        }
    }
}