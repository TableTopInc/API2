using TableTop.Inc.API.Data.AzureStorage.Table.Model.Base;
using TableTop.Inc.API.Infrastructure.Engine.Model.Object;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Object
{
    public sealed class TagObject: ObjectBase, ITagObject
    {
        public string Title { get; set; }
    }
}