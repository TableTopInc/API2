using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Link;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Link
{
    public class GameDesignerToGameLink: OneToManyContextLink, IGameDesignerToGameLink
    {
        [IgnoreProperty]
        public string GameId
        {
            get => ManyId;
            set => ManyId = value;
        }
        
        [IgnoreProperty]
        public string GameDesignerId
        {
            get => OneId;
            set => OneId = value;
        }
        
        [IgnoreProperty]
        public string GameDesignerRoleId
        {
            get => ContextId;
            set => ContextId = value;
        }
    }
}