namespace TableTop.Inc.API.Infrastructure.Engine.Model.Base
{
    public interface IOneToManyLink: IObjectBase
    {
        string OneId { get; set; }
        string ManyId { get; set; }
    }
}