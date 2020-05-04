using TableTop.Inc.API.Infrastructure.Engine.Model.Object;
using TableTop.Inc.API.Infrastructure.Engine.Service.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Service.General
{
    public interface IGameDesignerService<T>: IEntityService<T>
        where T: IGameDesignerObject
    {
    }
}