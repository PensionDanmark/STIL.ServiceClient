using System.Security.Cryptography.X509Certificates;

namespace STIL.ServiceClient.ConfigurationProviders
{
    /// <summary>
    /// The certificate provider.
    /// </summary>
    public interface ICertificateProvider
    {
        /// <summary>
        /// Gets the certificate by thumbprint.
        /// </summary>
        /// <param name="thumbprint">The certificate thumbprint to locate the certificate.</param>
        /// <returns>The <see cref="X509Certificate2"/> instance.</returns>
        X509Certificate2 GetCertificateByThumbprint(string thumbprint);
    }
}
