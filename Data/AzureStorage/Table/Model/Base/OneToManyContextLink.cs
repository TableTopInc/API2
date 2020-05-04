using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Data.AzureStorage.Table.Model.Base
{
    public abstract class OneToManyContextLink: OneToManyLink, IOneToManyContextLink
    {
        public string ContextId { get; set; }
    }
}