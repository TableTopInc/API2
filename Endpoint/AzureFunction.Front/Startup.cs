using Microsoft.Azure.Functions.Extensions.DependencyInjection;

namespace TableTop.Inc.API.Endpoint.AzureFunction.Front
{
    [assembly: FunctionsStartup(typeof(TableTop.Inc.API.Endpoint.AzureFunction.Front.Startup))]
    public class Startup: FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            throw new System.NotImplementedException();
        }
    }
}