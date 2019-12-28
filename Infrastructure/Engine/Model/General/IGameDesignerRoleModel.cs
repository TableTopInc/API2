using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.General
{
    public interface IGameDesignerRoleModel : IEntityModel
    {
        string Title { get; set; }
    }
}