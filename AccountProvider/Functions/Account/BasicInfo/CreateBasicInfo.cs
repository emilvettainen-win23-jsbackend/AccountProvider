using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AccountProvider.Functions.Account.BasicInfo
{
    public class CreateBasicInfo
    {
        private readonly ILogger<CreateBasicInfo> _logger;

        public CreateBasicInfo(ILogger<CreateBasicInfo> logger)
        {
            _logger = logger;
        }

        [Function("CreateBasicInfo")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
