using CSharpPenguin.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharpPenguin
{
    public static class MyFirstPenguin
    {
        [FunctionName("MyFirstPenguin")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", "options", Route = "penguin/{query:alpha}")]HttpRequest req, string query, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            if (req.Method == HttpMethod.Get.Method && query == "info")
            {
                var penguinInfo = new { name = "Pingu", team = "Bouvet#" };
                return new OkObjectResult(penguinInfo);
            }
            else if (req.Method == HttpMethod.Post.Method && query == "command")
            {
                try
                {
                    string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                    Match match = JsonConvert.DeserializeObject<Match>(requestBody);
                    var action = new Shared.Action(match);
                    var command = new { command = action.ChooseAction() };
                    return new OkObjectResult(command);
                }
                catch (Exception)
                {
                    return new BadRequestObjectResult("Wrong format");
                }
            }
            return new NotFoundObjectResult("Nothing happened");
        }
    }
}
