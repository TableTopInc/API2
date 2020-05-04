using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Link
{
    public interface ITagToGameLink : IOneToManyLink
    {
        string TagId { get; set; }
        string GameId { get; set; }
    }
}