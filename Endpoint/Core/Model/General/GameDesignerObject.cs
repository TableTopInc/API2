using TableTop.Inc.API.Endpoint.Core.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;

namespace TableTop.Inc.API.Endpoint.Core.Model.General
{
    public class GameDesignerObject: ObjectBase, IGameDesignerObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string PhotoUrl { get; set; }
    }
}