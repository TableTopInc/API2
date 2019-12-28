using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.General
{
    public interface ITagModel : IEntityModel
    {
        string Title { get; set; }

        string TagGroupId { get; set; }
    }
}