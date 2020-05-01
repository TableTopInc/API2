using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Object
{
    public interface IGameModel : IEntityModel
    {
        string Title { get; set; }
        string Description { get; set; }
        string CoverUrl { get; set; }
        int? PlayersFrom { get; set; }
        int? PlayersTo { get; set; }
        int? SessionMinutesFrom { get; set; }
        int? SessionMinutesTo { get; set; }
        int? AgeFrom { get; set; }
        int? YearReleased { get; set; }
    }
}