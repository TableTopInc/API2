using Microsoft.WindowsAzure.Storage.Table;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Data.AzureStorage.Table.Model.Object;
using TableTop.Inc.API.Data.AzureStorage.Table.Service.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Service.General
{
    public class GameDesignerService: EntityService<GameDesignerObject>
    {
        public GameDesignerService(CloudTable table, string entitiesOwnerId = ObjectBase.DefaultPartitionKey)
            : base(table, entitiesOwnerId)
        {
        }
    }
}