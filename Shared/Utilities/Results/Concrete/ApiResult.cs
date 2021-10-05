using System;
using Shared.Entities.ComplexTypes;
using Shared.Utilities.Results.ComplexTypes;

namespace Shared.Utilities.Results.Concrete
{
    public class ApiResult
    {
        public ApiResult(ResultStatus resultStatus,string message,HttpStatusCode httpStatusCode,string href)
        {

        }
        public ApiResult()
        {

        }
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Href { get; set; }
    }
}

