using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace STIL.ServiceClient.Tests.Util;

/// <summary>
/// Utility helper class for common helper methods.
/// </summary>
public static class TestHelper
{
    /// <summary>
    /// Creates a self signed certificate used for testing.
    /// </summary>
    /// <param name="subjectName">The subject name.</param>
    /// <param name="validFrom">Valid from date.</param>
    /// <param name="validTo">Validt to date.</param>
    /// <returns></returns>
    public static X509Certificate2 CreateSelfSignedCertificate(string subjectName, DateTime validFrom, DateTime validTo)
    {
        using var rsa = RSA.Create(2048);
        var req = new CertificateRequest($"CN={subjectName}", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        return req.CreateSelfSigned( validFrom, validTo);
    }

    /// <summary>
    /// Gets content from embedded file located in the samples folder.
    /// </summary>
    /// <param name="fileName">Name of the file. Ex. reponse.xml.</param>
    /// <returns>The string content of the embedded file.</returns>
    public static string GetXmlContentFromFile(string fileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        string fullFileName = $"{assembly.GetName().Name}.Samples.{fileName}" ?? throw new ArgumentNullException($"Filename {fileName} could not be found.");

        using (Stream? stream = assembly.GetManifestResourceStream(fullFileName) ?? throw new NullReferenceException($"No content found in file: {fileName} or file was not set as embedded resource."))
        {
            // Read the XML file from the stream
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
