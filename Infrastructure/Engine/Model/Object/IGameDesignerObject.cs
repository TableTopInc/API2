using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.Object
{
    public interface IGameDesignerObject : IObjectBase
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Bio { get; set; }
        string PhotoUrl { get; set; }
    }
}