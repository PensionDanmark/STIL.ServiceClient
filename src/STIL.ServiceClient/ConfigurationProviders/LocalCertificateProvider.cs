using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace STIL.ServiceClient.ConfigurationProviders
{
    /// <summary>
    /// Certificate provider for retrieving the certificate locally.
    /// </summary>
    public class LocalCertificateProvider : ICertificateProvider
    {
        /// <summary>
        /// Gets the certificate by thumbprint using the current user store location.
        /// This is the same location if using Azure as Cloud Provider and storing a private key certificate (.pfx) in the Web App Certificates.
        /// </summary>
        /// <param name="thumbprint">The certificate thumbprint.</param>
        /// <returns>The <see cref="X509Certificate2"/> instance.</returns>
        public X509Certificate2 GetCertificateByThumbprint(string thumbprint)
        {
            using var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            var thumbprints = string.Join(",", store.Certificates.OfType<X509Certificate2>().Select(c => c.Thumbprint));
            return store.Certificates
                .Find(X509FindType.FindByThumbprint, thumbprint, validOnly: false)
                .OfType<X509Certificate2>()
                .FirstOrDefault()
                   ?? throw new ArgumentNullException(nameof(thumbprint), $"No certificate was found in store location '{StoreName.My}:{StoreLocation.CurrentUser}' with thumbprint: '{thumbprint}' The following certificates are available: {thumbprints}");
        }
    }
}
