using Moq.Language.Flow;
using Moq.Protected;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using Moq.Language;

namespace STIL.ServiceClient.Tests.Extensions
{
    /// <summary>
    /// Moq http message handler extensions.
    /// Inspiration: https://github.com/maxkagamine/Moq.Contrib.HttpClient/
    /// </summary>
    public static class MoqExtensions
    {
        /// <summary>
        /// Specifies the response to return.
        /// </summary>
        /// <param name="setup">The setup.</param>
        /// <param name="statusCode">The status code.</param>
        /// <param name="configure">An action to configure the response headers.</param>
        public static IReturnsResult<HttpClientHandler> ReturnsResponse(
            this ISetup<HttpClientHandler, Task<HttpResponseMessage>> setup,
            HttpStatusCode statusCode,
            Action<HttpResponseMessage>? configure = null)
        {
            return setup.ReturnsAsync((HttpRequestMessage request, CancellationToken _) => CreateResponse(
                request: request,
                statusCode: statusCode,
                configure: configure));
        }

        /// <summary>
        /// Specifies a setup matching any request.
        /// </summary>
        /// <param name="handler">The <see cref="HttpClientHandler" /> mock.</param>
        public static ISetup<HttpClientHandler, Task<HttpResponseMessage>> SetupAnyRequest(this Mock<HttpClientHandler> handler)
            => handler.Setup(x => x.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()));

        /// <summary>
        /// Specifies a setup on the mocked type for a call to a value-returning method.
        /// </summary>
        /// <typeparam name="TResult">Type of the return value. Typically omitted as it can be inferred from the expression.</typeparam>
        /// <param name="handler">The <see cref="HttpClientHandler" /> mock.</param>
        /// <param name="expression">Lambda expression that specifies the expected method invocation.</param>
        private static ISetup<HttpClientHandler, TResult> Setup<TResult>(this Mock<HttpClientHandler> handler, Expression<Func<IHttpMessageHandler, TResult>> expression)
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
        /// Verifies that a specific invocation matching the given expression was performed on the mock.
        /// Use in conjunction with the default <see cref="MockBehavior.Loose" />.
        /// </summary>
        /// <typeparam name="TResult">Type of the return value. Typically omitted as it can be inferred from the expression.</typeparam>
        /// <param name="handler">The <see cref="HttpMessageHandler" /> mock.</param>
        /// <param name="expression">Lambda expression that specifies the method invocation.</param>
        /// <param name="times">
        /// Number of times that the invocation is expected to have occurred.
        /// If omitted, assumed to be <see cref="Times.AtLeastOnce" />.
        /// </param>
        /// <param name="failMessage">Message to include in the thrown <see cref="MockException" /> if verification fails.</param>
        /// <exception cref="MockException">The specified invocation did not occur (or did not occur the specified number of times).</exception>
        private static void Verify<TResult>(this Mock<HttpClientHandler> handler, Expression<Func<IHttpMessageHandler, TResult>> expression, Times? times = null, string? failMessage = null)
        {
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            handler.Protected().As<IHttpMessageHandler>().Verify(expression, times, failMessage);
        }

        /// <summary>
        /// Verifies that any request was sent.
        /// </summary>
        /// <param name="handler">The <see cref="HttpClientHandler" /> mock.</param>

        /// <param name="times">
        /// Number of times that the invocation is expected to have occurred.
        /// If omitted, assumed to be <see cref="Times.AtLeastOnce" />.
        /// </param>
        /// <param name="failMessage">Message to include in the thrown <see cref="MockException" /> if verification fails.</param>
        public static void VerifyAnyRequest(this Mock<HttpClientHandler> handler, Times? times = null, string? failMessage = null)
            => handler.Verify(x => x.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()), times, failMessage);


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
