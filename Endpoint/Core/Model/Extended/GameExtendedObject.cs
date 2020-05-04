using System.Collections.Generic;
using TableTop.Inc.API.Endpoint.Core.Model.General;

namespace TableTop.Inc.API.Endpoint.Core.Model.Extended
{
    public class GameExtendedObject: GameObject
    {
        private List<TagGroupExtendedObject> Tags { get; set; }
    }
}