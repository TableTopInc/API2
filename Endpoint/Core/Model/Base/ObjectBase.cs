using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Endpoint.Core.Model.Base
{
    public abstract class ObjectBase: IObjectBase
    {
        public string Id { get; set; }
    }
}