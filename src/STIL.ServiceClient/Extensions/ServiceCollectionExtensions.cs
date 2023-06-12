using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using STIL.ServiceClient.ConfigurationProviders;

namespace STIL.ServiceClient.Extensions
{
    /// <summary>
    /// Extension for adding DI Support.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds dependency registration for VEU STIL service client.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration app settings.</param>
        /// <param name="certificateProvider">The certificate provider. If none is provided the default <see cref="LocalCertificateProvider"/> will be registered.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddStilVeuServiceClient(this IServiceCollection services, IConfiguration configuration, ICertificateProvider? certificateProvider = null)
        {
            // Retrieve required configuration values.
            var stilConfig = configuration.GetRequiredSection("Stil");
            var baseUrl = stilConfig["BaseUrl"] ?? throw new ArgumentNullException("BaseUrl", "BaseUrl var not provided in the Stil configuration section.");
            var signingCertificateThumbprint = stilConfig["SigningCertificateThumbprint"] ?? throw new ArgumentNullException("SigningCertificateThumbprint", "SigningCertificateThumbprint is as minimum required in the Stil configuration section, for using this dependency registration.");

            // Retrieve optional client certificate thumbprint value.
            var clientCertificateThumbprint = stilConfig["ClientCertificateThumbprint"];

            // Add default implementation of ICertificateProvider if none is registered
            if (certificateProvider is null)
            {
                services.TryAddSingleton<ICertificateProvider, LocalCertificateProvider>();
            }
            else
            {
                services.TryAddSingleton<ICertificateProvider>(certificateProvider);
            }

            if (string.IsNullOrEmpty(clientCertificateThumbprint))
            {
                // Only signing certificate is provided, use the single certificate constructor
                services.AddSingleton<IStilVeuServiceClient>(sp =>
                {
                    var cProvider = sp.GetRequiredService<ICertificateProvider>();
                    return new StilVeuServiceClient(
                        baseUrl,
                        cProvider.GetCertificateByThumbprint(signingCertificateThumbprint));
                });
            }
            else
            {
                // Both certificates are provided, use the double certificate constructor
                services.AddSingleton<IStilVeuServiceClient>(sp =>
                {
                    var cProvider = sp.GetRequiredService<ICertificateProvider>();
                    return new StilVeuServiceClient(
                        baseUrl,
                        cProvider.GetCertificateByThumbprint(clientCertificateThumbprint!),
                        cProvider.GetCertificateByThumbprint(signingCertificateThumbprint));
                });
            }

            return services;
        }
    }
}
