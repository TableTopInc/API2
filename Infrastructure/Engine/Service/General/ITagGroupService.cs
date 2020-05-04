using System.Collections.Generic;
using System.Threading.Tasks;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;
using TableTop.Inc.API.Infrastructure.Engine.Service.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Service.General
{
    public interface ITagGroupService: IEntityService<ITagGroupObject>
    {
        Task<IEnumerable<ITagObject>> GetTagsAsync(string tagGroupId);
    }
}