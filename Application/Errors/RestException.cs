using System;
using System.Net;

namespace Application.Errors
{
    public class RestException : Exception
    {
        public object Errors { get; }
        public HttpStatusCode Code { get; }
        public RestException(HttpStatusCode code, object errors = null)
        {
            Code = code;
            Errors = errors;
        }
    }
}