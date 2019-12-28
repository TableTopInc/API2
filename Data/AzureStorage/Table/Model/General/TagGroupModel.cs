using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.General;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.General
{
    public sealed class TagGroupModel: EntityModel, ITagGroupModel
    {
        public string Title { get; set; }
    }
}