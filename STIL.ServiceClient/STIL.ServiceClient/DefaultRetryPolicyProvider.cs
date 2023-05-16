using Polly;
using Polly.Extensions.Http;
using Polly.Retry;
using System;
using System.Net;
using System.Net.Http;

namespace STIL.ServiceClient
{
    /// <summary>
    /// Default retry policy provider.
    /// </summary>
    public class DefaultRetryPolicyProvider : IRetryPolicyProvider
    {
        private static AsyncRetryPolicy<HttpResponseMessage> DefaultRetryPolicy { get; } = Policy.Handle<HttpRequestException>()
            .OrTransientHttpError()
            .WaitAndRetryAsync(
                retryCount: 1,
                sleepDurationProvider: retryAttempt =>
                    TimeSpan.FromSeconds(5));

        /// <summary>
        /// The retry policy to apply to the send async request.
        /// </summary>
        /// <returns>An instance of <see cref="AsyncRetryPolicy"/>.</returns>
        public AsyncRetryPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return DefaultRetryPolicy;
        }
    }
}
