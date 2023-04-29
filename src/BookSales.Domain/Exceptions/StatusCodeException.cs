using System.Net;

namespace BookSales.Domain.Exceptions
{
    public class StatusCodeException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public StatusCodeException(HttpStatusCode httpStatusCode, string message)
            : base(message)
        {
            StatusCode = httpStatusCode;
        }
    }
}
