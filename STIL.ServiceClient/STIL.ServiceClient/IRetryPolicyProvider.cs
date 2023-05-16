using Polly.Retry;
using System.Net.Http;

namespace STIL.ServiceClient
{
    /// <summary>
    /// Retry policy provider interface.
    /// </summary>
    public interface IRetryPolicyProvider
    {
        /// <summary>
        /// Get retry policy.
        /// </summary>
        /// <returns>The <see cref="HttpResponseMessage"/>.</returns>
        AsyncRetryPolicy<HttpResponseMessage> GetRetryPolicy();
    }
}
