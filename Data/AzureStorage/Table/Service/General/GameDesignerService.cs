using System.Collections.Generic;
using System.Threading.Tasks;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.General;
using TableTop.Inc.API.Data.AzureStorage.Table.Service.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Service.General
{
    public sealed class GameDesignerService: EntityService<GameDesignerModel>
    {
        public override async Task<IEnumerable<GameDesignerModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public override async Task GetByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public override async Task SaveAsync(GameDesignerModel model)
        {
            throw new System.NotImplementedException();
        }

        public override async Task DeleteByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}