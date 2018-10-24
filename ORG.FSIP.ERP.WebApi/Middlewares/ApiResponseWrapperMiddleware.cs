using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ORG.FSIP.ERP.WebApi.Wrappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.WebApi.Middlewares
{
    public class ApiResponseWrapperMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiResponseWrapperMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var currentBody = context.Response.Body;

            using (var memoryStream = new MemoryStream())
            {
                //set the current response to the memorystream.
                context.Response.Body = memoryStream;

                await _next(context);

                //reset the body 
                context.Response.Body = currentBody;
                memoryStream.Seek(0, SeekOrigin.Begin);

                var readToEnd = new StreamReader(memoryStream).ReadToEnd();
                var objResult = JsonConvert.DeserializeObject(readToEnd);
                var result = ApiResponseWrapper.Create((HttpStatusCode)context.Response.StatusCode, objResult, null);

                await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
            }
        }
    }
}
