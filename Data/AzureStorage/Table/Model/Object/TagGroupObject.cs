using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.General
{
    public sealed class TagGroupObject: ObjectBase, ITagGroupObject
    {
        public string Title { get; set; }
    }
}