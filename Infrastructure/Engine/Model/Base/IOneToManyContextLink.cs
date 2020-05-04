namespace TableTop.Inc.API.Infrastructure.Engine.Model.Base
{
    public interface IOneToManyContextLink: IOneToManyLink
    {
        string ContextId { get; set; }
    }
}