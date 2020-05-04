using System.Collections.Generic;
using System.Threading.Tasks;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;
using TableTop.Inc.API.Infrastructure.Engine.Service.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Service.General
{
    public interface IGameService: IEntityService<IGameObject>
    {
        Task<IEnumerable<IGameObject>> GetGamesByGameDesignerIdAsync(params string[] gameDesignerId);
        
        Task<IEnumerable<(IGameDesignerObject GameDesigner, IGameDesignerRoleObject GameDesignerRole)>> GetGameDesignersAsync(string gameId);
        Task<IEnumerable<(ITagGroupObject TagGroup, IEnumerable<ITagObject> Tags)>> GetTagsAsync(string gameId);
    }
}