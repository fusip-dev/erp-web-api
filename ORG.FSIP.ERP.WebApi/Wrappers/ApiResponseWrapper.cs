using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.WebApi.Wrappers
{
    public class ApiResponseWrapper
    {
        public Dictionary<string, object> ResultData { get; set; }

        private const string RequestId = "request";

        private const string StatusCode = "status";

        private const string Data = "data";

        private const string Message = "message";

        public ApiResponseWrapper(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            ResultData = new Dictionary<string, object>{
                {RequestId, Guid.NewGuid() },
                {StatusCode, statusCode }
            };

            if (result != null)
            {
                ResultData.Add(Data, result);
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                ResultData.Add(Message, errorMessage);
            }


        }

        public static Dictionary<string, object> Create(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            return new ApiResponseWrapper(statusCode, result, errorMessage).ResultData;
        }
    }
}
