using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;

namespace TableTop.Inc.API.Endpoint.AzureFunction.Worker.Activity.Service
{
    public class GameDesignerActivity
    {
        internal const string Prefix = nameof(GameDesignerActivity);
        
        internal const string Save = Prefix + "-" + nameof(Save);
        
        [FunctionName(Save)]
        public async Task SaveAsync([ActivityTrigger] string name, ILogger log)
        {
            throw new NotImplementedException();
        }
    }
}