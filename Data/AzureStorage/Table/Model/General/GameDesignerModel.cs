using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.General;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.General
{
    public sealed class GameDesignerModel: EntityModel, IGameDesignerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string PhotoUrl { get; set; }
    }
}