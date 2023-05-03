using System;
using System.Collections.Generic;

namespace STIL.ServiceClient.Properties
{
    public class ApiException : Exception
    {
        public int StatusCode { get; private set; }

        public string? Response { get; private set; }

        public string? RequestUrl { get; private set; }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string? response, string? requestUrl, IReadOnlyDictionary<string, IEnumerable<string>>? headers, Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            RequestUrl = requestUrl;
            Headers = headers;
        }
    }
}
