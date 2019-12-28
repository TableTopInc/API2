using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.General
{
    public interface ITagGroupModel : IEntityModel
    {
        string Title { get; set; }
    }
}