using TableTop.Inc.API.Endpoint.Core.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;

namespace TableTop.Inc.API.Endpoint.Core.Model.General
{
    public class GameDesignerRoleObject: ObjectBase, IGameDesignerRoleObject
    {
        public string Title { get; set; }
    }
}