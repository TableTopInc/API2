using System.Collections.Generic;
using System.Threading.Tasks;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Service.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Service.Base
{
    public abstract class EntityService<T>: IEntityService<T> where T : EntityModel
    {
        public abstract Task<IEnumerable<T>> GetAllAsync();
        public abstract Task GetByIdAsync(string id);
        public abstract Task SaveAsync(T model);
        public abstract Task DeleteByIdAsync(string id);
    }
}