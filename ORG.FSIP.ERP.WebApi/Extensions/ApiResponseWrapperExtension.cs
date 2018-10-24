using Microsoft.AspNetCore.Builder;
using ORG.FSIP.ERP.WebApi.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.WebApi.Extensions
{
    public static class ApiResponseWrapperExtension
    {
        public static IApplicationBuilder UseApiResponseWrapper(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApiResponseWrapperMiddleware>();
        }
    }
}
