using System;
using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.TestApp.Examples;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.TestApp
{
    public static class Get_Path_ParameterExamples_HttpTrigger
    {
        [FunctionName(nameof(Get_Path_ParameterExamples_HttpTrigger))]
        [OpenApiOperation(operationId: nameof(Get_Path_ParameterExamples_HttpTrigger.Get_Path_ParameterExamples), tags: new[] { "parameterExamples" })]
        [OpenApiParameter(verb: "GET",name: "stringParameter", In = ParameterLocation.Path, Required = true, Example = typeof(StringParameterExample), Type = typeof(string), Description = "The **string** parameter")]
        [OpenApiParameter(verb: "GET",name: "int16Parameter", In = ParameterLocation.Path, Required = true, Example = typeof(Int16ParameterExample), Type = typeof(short), Description = "The **int16** parameter")]
        [OpenApiParameter(verb: "GET",name: "int32Parameter", In = ParameterLocation.Path, Required = true, Example = typeof(Int32ParameterExample), Type = typeof(int), Description = "The **int32** parameter")]
        [OpenApiParameter(verb: "GET",name: "int64Parameter", In = ParameterLocation.Path, Required = true, Example = typeof(Int64ParameterExample), Type = typeof(long), Description = "The **int64** parameter")]
        [OpenApiParameter(verb: "GET",name: "uint16Parameter", In = ParameterLocation.Path, Required = true, Example = typeof(Uint16ParameterExample), Type = typeof(ushort), Description = "The **uint16** parameter")]
        [OpenApiParameter(verb: "GET",name: "uint32Parameter", In = ParameterLocation.Path, Required = true, Example = typeof(Uint32ParameterExample), Type = typeof(uint), Description = "The **uint32** parameter")]
        [OpenApiParameter(verb: "GET",name: "uint64Parameter", In = ParameterLocation.Path, Required = true, Example = typeof(Uint64ParameterExample), Type = typeof(ulong), Description = "The **uint64** parameter")]
        [OpenApiParameter(verb: "GET",name: "singleParameter", In = ParameterLocation.Path, Required = true, Example = typeof(SingleParameterExample), Type = typeof(float), Description = "The **single** parameter")]
        [OpenApiParameter(verb: "GET",name: "doubleParameter", In = ParameterLocation.Path, Required = true, Example = typeof(DoubleParameterExample), Type = typeof(double), Description = "The **double** parameter")]
        [OpenApiParameter(verb: "GET",name: "dateTimeParameter", In = ParameterLocation.Path, Required = true, Example = typeof(DateTimeParameterExample), Type = typeof(DateTime), Description = "The **dateTime** parameter")]
        [OpenApiParameter(verb: "GET",name: "dateTimeOffsetParameter", In = ParameterLocation.Path, Required = true, Example = typeof(DateTimeOffsetParameterExample), Type = typeof(DateTimeOffset), Description = "The **dateTimeOffset** parameter")]
        [OpenApiParameter(verb: "GET",name: "booleanParameter", In = ParameterLocation.Path, Required = true, Example = typeof(BooleanParameterExample), Type = typeof(bool), Description = "The **boolean** parameter")]
        [OpenApiParameter(verb: "GET",name: "guidParameter", In = ParameterLocation.Path, Required = true, Example = typeof(GuidParameterExample), Type = typeof(Guid), Description = "The **guid** parameter")]
        [OpenApiResponseWithBody(verb: "GET", statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        public static async Task<IActionResult> Get_Path_ParameterExamples(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "get-path-parameter-examples")] HttpRequest req,
            ILogger log)
        {
            var result  = new OkResult();

            return await Task.FromResult(result).ConfigureAwait(false);
        }
    }
}
