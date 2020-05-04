using System.Collections.Generic;
using System.Threading.Tasks;
using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Service.Base
{
    public interface IEntityService<T> where T: IObjectBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetByIdAsync(params string[] ids);
        Task<IEnumerable<T>> SaveAsync(params T[] models);
        Task DeleteByIdAsync(params string[] ids);
    }
}