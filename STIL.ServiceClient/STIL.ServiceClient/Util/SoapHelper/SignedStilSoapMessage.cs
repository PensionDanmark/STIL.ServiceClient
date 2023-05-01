using System.Security.Cryptography.X509Certificates;

namespace STIL.ServiceClient.Util.SoapHelper
{
    /// <summary>
    /// Represents a Soap request for STIL (Styrelsen for IT og Læring)
    /// </summary>
    /// <typeparam name="T">The type of the Soap body content.</typeparam>
    public class StilSoapMessage<T>
    {
        private readonly T _data;

        /// <summary>
        /// Initializes a new instance of the <see cref="StilSoapMessage{T}"/> class.
        /// </summary>
        /// <param name="data">The contents of the soap body.</param>
        public StilSoapMessage(T data)
        {
            _data = data;
        }

        /// <summary>
        /// Gets a signed SOAP message as a string.
        /// </summary>
        /// <param name="signingCertificate">The certificate used to sign the document</param>
        /// <remarks>WARNING: Do not reformat the returned XML, as changes to the whitespace will invalidate the signature.</remarks>
        public string GetSignedXml(X509Certificate2 signingCertificate)
        {
            var builder = new StilSoapBuilder<T>(_data);
            var unsignedSoapMessage = builder.BuildUnsignedSoapMessage(signingCertificate);
            var signer = new SoapSigner(unsignedSoapMessage, signingCertificate, builder.TokenId);
            var signedDocument = signer.GetSignedXml();

            return signedDocument;
        }
    }
}