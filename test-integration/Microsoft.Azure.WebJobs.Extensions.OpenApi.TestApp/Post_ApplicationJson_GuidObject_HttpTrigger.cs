using System;
using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.TestApp.Models;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.TestApp
{
    public static class Post_ApplicationJson_GuidObject_HttpTrigger
    {
        [FunctionName(nameof(Post_ApplicationJson_GuidObject_HttpTrigger))]
        [OpenApiOperation(operationId: nameof(Post_ApplicationJson_GuidObject_HttpTrigger), tags: new[] { "guid" })]
        [OpenApiRequestBody(verb: "GET",contentType: "text/plain", bodyType: typeof(Guid), Required = true, Description = "The OK response")]
        [OpenApiResponseWithBody(verb: "GET",statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(GuidObjectModel), Description = "The OK response")]
        public static async Task<IActionResult> Post_ApplicationJson_GuidObject(
            [HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "post-applicationjson-guid")] HttpRequest req,
            ILogger log)
        {
            var result  = new OkResult();

            return await Task.FromResult(result).ConfigureAwait(false);
        }
    }
}
