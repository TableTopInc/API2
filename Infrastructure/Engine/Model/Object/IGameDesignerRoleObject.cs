using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Object
{
    public interface IGameDesignerRoleModel : IEntityModel
    {
        string Title { get; set; }
    }
}