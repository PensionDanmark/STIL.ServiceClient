using System.Threading;
using System.Threading.Tasks;

namespace STIL.ServiceClient
{
    /// <summary>
    /// Internal STIL service client responsible for sending the soap request and instantiating http client.
    /// </summary>
    internal interface IStilServiceClient
    {
        /// <summary>
        /// Send Soap Request method.
        /// Can be overridden in any derived classes.
        /// </summary>
        /// <typeparam name="TRequest">The request type.</typeparam>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <typeparam name="TServiceFaultDetailer">The service fault detailer type.</typeparam>
        /// <param name="methodName">The method name used in request uri.</param>
        /// <param name="dataRequest">The data request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response instance of <typeparamref name="TResponse"/>.</returns>
        Task<TResponse> SendSoapRequest<TRequest, TResponse, TServiceFaultDetailer>(string methodName, TRequest dataRequest, CancellationToken cancellationToken = default)
            where TRequest : class
            where TResponse : class
            where TServiceFaultDetailer : class;
    }
}