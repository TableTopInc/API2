using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Object
{
    public interface ITagGroupModel : IEntityModel
    {
        string Title { get; set; }
    }
}