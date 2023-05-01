using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;
using STIL.SoapHelper;

namespace STIL.ServiceClient.Util.SoapHelper
{
    /// <summary>
    /// Helper class for creating a SOAP signature.
    /// </summary>
    internal class SoapSigner
    {
        private readonly X509Certificate2 _signingCertificate;
        private readonly XDocument _soapMessage;
        private readonly Guid _tokenId;
        private readonly XNamespace securityWSNs = XNamespace.Get("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");

        /// <summary>
        /// Initializes a new instance of the <see cref="SoapSigner"/> class.
        /// </summary>
        /// <param name="soapMessage">The SOAP message to sign.</param>
        /// <param name="signingCertificate">The certificate to use for signing the SOAP message.</param>
        /// <param name="tokenId">The GUID part of the id element that identifies the signing certificate.</param>
        public SoapSigner(XDocument soapMessage, X509Certificate2 signingCertificate, Guid tokenId)
        {
            _signingCertificate = signingCertificate;
            _soapMessage = soapMessage;
            _tokenId = tokenId;
        }
        

        /// <summary>
        /// Signs the SOAP message.
        /// </summary>
        /// <returns>A signed SOAP message.</returns>
        /// <remarks>WARNING: Do not reformat the returned XML, as the added whitespace will break the signature.</remarks>
        public string GetSignedXml()
        {
            var xmlDocument = new XmlDocument {PreserveWhitespace = false};
            xmlDocument.Load(_soapMessage.CreateReader(ReaderOptions.OmitDuplicateNamespaces));
            
            var signatureGenerator = GetXmlSigner(_signingCertificate, xmlDocument);
            AddBodyReference(signatureGenerator);
            AddTimestampReference(signatureGenerator);
            AddSecurityTokenReference(_tokenId, signatureGenerator);
            
            signatureGenerator.ComputeSignature();
            var signature = signatureGenerator.GetXml();
            AppendComputedSignature(xmlDocument, signature);

            return xmlDocument.OuterXml;
        }
        
        /// <summary>
        /// Append the computed signature to the 'Security' element in the SOAP Header.
        /// </summary>
        /// <param name="xmlDocument">The document containing the unsigned SOAP message.</param>
        /// <param name="signature">The signature to append to the unsigned SOAP message.</param>
        private static void AppendComputedSignature(XmlDocument xmlDocument, XmlElement signature)
        {
            var validator = new SoapMessageValidator(xmlDocument);
            var securityNode = validator.FindSecurityElement();
            securityNode.AppendChild(signature);
        }
        
        /// <summary>
        /// Add a reference to the public key of the certificate used to sign the document.
        /// </summary>
        /// <param name="tokenId">The GUID part of the signing certificate id.</param>
        /// <param name="signedXml">The signed XML to add the certificate reference to.</param>
        private void AddSecurityTokenReference(Guid tokenId, SignedXml signedXml)
        {
            signedXml.KeyInfo = new KeyInfo();
            var securityTokenReference = new XElement(securityWSNs + "SecurityTokenReference",
                    new XElement(securityWSNs + "Reference",
                        new XAttribute("ValueType", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3"),
                        new XAttribute("URI", $"#SecurityToken-{tokenId}")))
                .ToXmlElement();
            signedXml.KeyInfo.AddClause(new KeyInfoNode(securityTokenReference));
        }
        
        /// <summary>
        /// Add a reference to the Timestamp element.
        /// </summary>
        /// <param name="signedXml">The signed XML to add the timestamp reference to.</param>
        private static void AddTimestampReference(SignedXml signedXml)
        {
            var timestampRef = new Reference($"#TimestampRef");
            timestampRef.AddTransform(new XmlDsigExcC14NTransform());
            timestampRef.DigestMethod = System.Security.Cryptography.Xml.SignedXml.XmlDsigSHA1Url;
            signedXml.AddReference(timestampRef);
        }
        
        /// <summary>
        /// Add a reference to the SOAP Body element.
        /// </summary>
        /// <param name="signedXml">The signed XML to add the body reference to.</param>
        private static void AddBodyReference(SignedXml signedXml)
        {
            var bodyRef = new Reference("#BodyRef");
            bodyRef.AddTransform(new XmlDsigExcC14NTransform());
            bodyRef.DigestMethod = SignedXml.XmlDsigSHA1Url;
            signedXml.AddReference(bodyRef);
        }
        
        /// <summary>
        /// Creates a new instance of the <see cref="SignedXmlWithNamespacedIdElement"/> class
        /// with the supplied certificate and <see cref="XmlDocument"/>.
        /// </summary>
        /// <param name="signingCertificate">The certificate to be used for computing the XML signature.</param>
        /// <param name="xmlDocument">The document to be signed.</param>
        /// <returns></returns>
        private static SignedXml GetXmlSigner(X509Certificate2 signingCertificate, XmlDocument xmlDocument)
        {
            return new SignedXmlWithNamespacedIdElement(xmlDocument)
            {
                SigningKey = signingCertificate.GetRSAPrivateKey(),
                SignedInfo =
                {
                    CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl,
                    SignatureMethod = SignedXml.XmlDsigRSASHA1Url
                }
            };
        }
    }
}