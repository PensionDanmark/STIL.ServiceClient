using Polly.Retry;
using System.Net.Http;

namespace STIL.ServiceClient.ConfigurationProviders
{
    /// <summary>
    /// Retry policy provider interface.
    /// </summary>
    public interface IRetryPolicyProvider
    {
        /// <summary>
        /// The retry policy to apply to the send async request.
        /// </summary>
        /// <returns>An instance of <see cref="AsyncRetryPolicy{HttpResponseMessage}"/>.</returns>
        AsyncRetryPolicy<HttpResponseMessage> GetRetryPolicy();
    }
}
