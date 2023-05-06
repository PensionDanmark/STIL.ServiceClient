using System;
using System.Collections.Generic;

namespace STIL.ServiceClient.Properties
{
    /// <summary>
    /// Api Exception class used for soap exceptions containing additional information about the request and response.
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// The http status code.
        /// </summary>
        public int StatusCode { get; private set; }

        /// <summary>
        /// The response.
        /// </summary>
        public string? Response { get; private set; }

        /// <summary>
        /// The request url.
        /// </summary>
        public string? RequestUrl { get; private set; }

        /// <summary>
        /// The request headers.
        /// </summary>
        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        /// <param name="message">The failure message.</param>
        /// <param name="statusCode">The http status code.</param>
        /// <param name="response">The response.</param>
        /// <param name="requestUrl">The request url.</param>
        /// <param name="headers">The request headers.</param>
        /// <param name="innerException">Any inner exception thrown.</param>
        public ApiException(string message, int statusCode, string? response, string? requestUrl, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 2048 ? 2048 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            RequestUrl = requestUrl;
            Headers = headers;
        }
    }
}
