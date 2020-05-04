using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Object
{
    public interface ITagObject : IObjectBase
    {
        string Title { get; set; }
    }
}