using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.General;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.General
{
    public sealed class GameDesignerRoleModel: EntityModel, IGameDesignerRoleModel
    {
        public string Title { get; set; }
    }
}