using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AccountProvider.Functions.Account.BasicInfo
{
    public class UpdateBasicInfo
    {
        private readonly ILogger<UpdateBasicInfo> _logger;

        public UpdateBasicInfo(ILogger<UpdateBasicInfo> logger)
        {
            _logger = logger;
        }

        [Function("UpdateBasicInfo")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
