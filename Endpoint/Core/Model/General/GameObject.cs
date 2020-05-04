using TableTop.Inc.API.Endpoint.Core.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;

namespace TableTop.Inc.API.Endpoint.Core.Model.General
{
    public class GameObject: ObjectBase, IGameObject
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