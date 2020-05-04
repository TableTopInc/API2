using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Link
{
    public interface IGameDesignerToGameLink: IOneToManyContextLink
    {
        string GameId { get; set; }
        string GameDesignerId { get; set; }
        string GameDesignerRoleId { get; set; }
    }
}