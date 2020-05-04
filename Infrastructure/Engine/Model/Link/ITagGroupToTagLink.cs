using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Link
{
    public interface ITagGroupToTagLink: IOneToManyLink
    {
        string TagGroupId { get; set; }
        string TagId { get; set; }
    }
}