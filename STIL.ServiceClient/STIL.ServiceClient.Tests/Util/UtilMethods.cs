using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public static class UtilMethods
{
    public static X509Certificate2 CreateSelfSignedCertificate(string subjectName, DateTime validFrom, DateTime validTo)
    {
        // Create a new RSA key pair
        using var rsa = RSA.Create(2048);

        // Create a certificate request with the subject name and public key
        var request = new CertificateRequest($"CN={subjectName}", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

        // Set the validity dates for the certificate
        request.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, false, 0, true));
        request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DigitalSignature, false));
        request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(new OidCollection { new Oid("1.3.6.1.5.5.7.3.1") }, false));
        request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

        var certificate = request.CreateSelfSigned(validFrom, validTo);

        return new X509Certificate2(certificate.Export(X509ContentType.Pfx), (string)null, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
    }

    public static string GetXmlContentFromFile(string fileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        using (Stream stream = assembly.GetManifestResourceStream($"STIL.ServiceClient.Tests.Samples.{fileName}"))
        {
            // Read the XML file from the stream
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
