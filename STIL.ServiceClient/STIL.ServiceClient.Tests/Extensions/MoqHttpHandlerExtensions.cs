using Moq;
using Moq.Language.Flow;
using Moq.Protected;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Headers;

namespace STIL.ServiceClient.Tests.Extensions
{
    /// <summary>
    /// Moq http handler extensions.
    /// Source: https://github.com/maxkagamine/Moq.Contrib.HttpClient/
    /// </summary>
    public static class MoqHttpHandlerExtensions
    {
        /// <summary>
        /// Creates a new <see cref="HttpClient" /> backed by this handler.
        /// </summary>
        /// <param name="handler">The <see cref="HttpMessageHandler" /> mock.</param>
        public static HttpClient CreateClient(this Mock<HttpMessageHandler> handler)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            return new HttpClient(handler.Object, false);
        }

        /// <summary>
        /// Specifies the response to return.
        /// </summary>
        /// <param name="setup">The setup.</param>
        /// <param name="statusCode">The status code.</param>
        /// <param name="configure">An action to configure the response headers.</param>
        public static IReturnsResult<HttpMessageHandler> ReturnsResponse(
            this ISetup<HttpMessageHandler, Task<HttpResponseMessage>> setup,
            HttpStatusCode statusCode,
            Action<HttpResponseMessage>? configure = null)
        {
            return setup.ReturnsAsync((HttpRequestMessage request, CancellationToken _) =>
            {
                return CreateResponse(
                    request: request,
                    statusCode: statusCode,
                    configure: configure);
            });
        }

        /// <summary>
        /// Specifies a setup matching any request.
        /// </summary>
        /// <param name="handler">The <see cref="HttpMessageHandler" /> mock.</param>
        public static ISetup<HttpMessageHandler, Task<HttpResponseMessage>> SetupAnyRequest(this Mock<HttpMessageHandler> handler)
            => handler.Setup(x => x.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()));

        /// <summary>
        /// Specifies a setup on the mocked type for a call to a value-returning method.
        /// </summary>
        /// <typeparam name="TResult">Type of the return value. Typically omitted as it can be inferred from the expression.</typeparam>
        /// <param name="handler">The <see cref="HttpMessageHandler" /> mock.</param>
        /// <param name="expression">Lambda expression that specifies the expected method invocation.</param>
        private static ISetup<HttpMessageHandler, TResult> Setup<TResult>(this Mock<HttpMessageHandler> handler, Expression<Func<IHttpMessageHandler, TResult>> expression)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            return handler.Protected().As<IHttpMessageHandler>().Setup(expression);
        }

        private static HttpResponseMessage CreateResponse(
            HttpRequestMessage? request = null,
            HttpStatusCode statusCode = HttpStatusCode.OK,
            HttpContent? content = null,
            string? mediaType = null,
            Action<HttpResponseMessage>? configure = null)
        {
            var response = new HttpResponseMessage(statusCode)
            {
                RequestMessage = request,
                Content = content
            };

            if (content != null && mediaType != null)
            {
                content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
            }

            configure?.Invoke(response);
            return response;
        }

        

        /// <summary>
        /// An interface to facilitate mocking the protected <see cref="HttpMessageHandler.SendAsync(HttpRequestMessage, CancellationToken)" /> method.
        /// </summary>
        public interface IHttpMessageHandler
        {
            /// <summary>
            /// Send an HTTP request as an asynchronous operation.
            /// </summary>
            /// <param name="request">The HTTP request message to send.</param>
            /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
            /// <returns>The task object representing the asynchronous operation.</returns>
            /// <exception cref="ArgumentNullException">The request was null.</exception>
            Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
        }
    }
}
