using System.Collections.Generic;
using System.Threading.Tasks;
using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Service.Base
{
    public interface IEntityService<T> where T: IEntityModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task GetByIdAsync(string id);
        
        Task SaveAsync(T model);
        Task DeleteByIdAsync(string id);
    }
}