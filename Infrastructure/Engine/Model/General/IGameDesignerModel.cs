using TableTop.Inc.API.Infrastructure.Engine.Model.Base;

namespace TableTop.Inc.API.Infrastructure.Engine.Model.General
{
    public interface IGameDesignerModel : IEntityModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Bio { get; set; }

        string PhotoUrl { get; set; }
    }
}