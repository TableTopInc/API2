using TableTop.Inc.API.Endpoint.Core.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;

namespace TableTop.Inc.API.Endpoint.Core.Model.General
{
    public class TagGroupObject: ObjectBase, ITagGroupObject
    {
        public string Title { get; set; }
    }
}