using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.General;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.General
{
    public sealed class GameModel: EntityModel, IGameModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public int? PlayersFrom { get; set; }
        public int? PlayersTo { get; set; }
        public int? SessionMinutesFrom { get; set; }
        public int? SessionMinutesTo { get; set; }
        public int? AgeFrom { get; set; }
        public int? YearReleased { get; set; }
    }
}