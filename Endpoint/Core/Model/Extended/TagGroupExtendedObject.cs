using System.Collections.Generic;
using TableTop.Inc.API.Endpoint.Core.Model.General;

namespace TableTop.Inc.API.Endpoint.Core.Model.Extended
{
    public class TagGroupExtendedObject: TagGroupObject
    {
        public List<TagObject> Tags { get; set; }
    }
}