using TableTop.Inc.API.Endpoint.Core.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;

namespace TableTop.Inc.API.Endpoint.Core.Model.General
{
    public class TagObject: ObjectBase, ITagObject
    {
        public string Title { get; set; }
    }
}