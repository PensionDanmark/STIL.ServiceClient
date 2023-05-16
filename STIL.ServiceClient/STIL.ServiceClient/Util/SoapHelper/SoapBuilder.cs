using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using STIL.SoapHelper;

namespace STIL.ServiceClient.Util.SoapHelper
{
    /// <summary>
    /// Helper class for building a SOAP message for STIL.
    /// </summary>
    /// <typeparam name="T">The type of the SOAP Body content.</typeparam>
    internal class SoapBuilder<T>
    {
        private const string ValueType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3";
        private const string EncodingType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary";
        private readonly T _body;
        private readonly XNamespace soapenvNs = XNamespace.Get("http://www.w3.org/2003/05/soap-envelope");
        private readonly XNamespace securityUtilNs = XNamespace.Get("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");
        private readonly XNamespace securityWSNs = XNamespace.Get("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
        private readonly XNamespace xsiNs = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");
        private readonly XNamespace xsdNs = XNamespace.Get("http://www.w3.org/2001/XMLSchema");

        /// <summary>
        /// Initializes a new instance of the <see cref="SoapBuilder{T}"/> class.
        /// </summary>
        /// <param name="body">The element to be placed in the SOAP body of the SOAP message.</param>
        public SoapBuilder(T body)
        {
            _body = body;
        }

        /// <summary>
        /// Gets the identifier that identifies the signing certificate element (a.k.a. BinarySecurityToken).
        /// </summary>
        public Guid TokenId { get; private set; }

        /// <summary>
        /// Builds an unsigned SOAP message. This constructs all parts needed to sign the SOAP Envelope.
        /// </summary>
        /// <param name="signingCertificate">The certificate that will be used to sign the message.</param>
        /// <returns>A document ready to be signed with the signing certificate.</returns>
        public XDocument BuildUnsignedSoapMessage(X509Certificate2 signingCertificate)
        {
            var document = new XDocument(new XDeclaration("1.0", "utf-8", null));
            AddEnvelope(document);
            TokenId = AddHeader(document, signingCertificate);
            AddBody(document);

            return document;
        }

        /// <summary>
        /// Adds the SOAP body contents.
        /// </summary>
        /// <param name="document">The document to attach the body content to.</param>
        private void AddBodyContents(XDocument document)
        {
            var bodyElement = document.Descendants(soapenvNs + "Body").Single();
            bodyElement.Add(
                new XElement(_body.Serialize()));
        }

        /// <summary>
        /// Adds the SOAP Body element.
        /// </summary>
        /// <param name="document">The document to add the SOAP body element to.</param>
        private void AddBody(XDocument document)
        {
            var envelope = document.Root;
            envelope.Add(
                new XElement(
                    soapenvNs + "Body",
                    new XAttribute(securityUtilNs + "Id", "BodyRef"),
                    new XAttribute(XNamespace.Xmlns + "xsi", xsiNs),
                    new XAttribute(XNamespace.Xmlns + "xsd", xsdNs)));
            AddBodyContents(document);
        }

        /// <summary>
        /// Adds the top level SOAP Envelope element.
        /// </summary>
        /// <param name="document">The document to add the envelope to.</param>
        private void AddEnvelope(XDocument document)
        {
            document.Add(new XElement(
                soapenvNs + "Envelope",
                new XAttribute(XNamespace.Xmlns + "s", soapenvNs),
                new XAttribute(XNamespace.Xmlns + "u", securityUtilNs)));
        }

        /// <summary>
        /// Adds the SOAP Header element.
        /// </summary>
        /// <param name="document">The document to add the header to.</param>
        /// <param name="signingCertificate">The certificate which will be used to sign the document.</param>
        /// <returns>A part of the identifier that identifies the signing certificate element.</returns>
        private Guid AddHeader(XDocument document, X509Certificate2 signingCertificate)
        {
            var envelope = document.Root;
            envelope.Add(new XElement(soapenvNs + "Header"));
            AddSecurityElement(document);
            AddTimeStamp(document);
            var tokenId = AddBinarySecurityToken(document, signingCertificate);
            return tokenId;
        }

        /// <summary>
        /// Adds the public key of the certificate that will be used to sign the document.
        /// </summary>
        /// <param name="document">The document to add the certificate to.</param>
        /// <param name="signingCertificate">The certificate that will be used to sign the document with.</param>
        /// <returns>A part of the identifier that identifies the signing certificate element.</returns>
        private Guid AddBinarySecurityToken(XDocument document, X509Certificate2 signingCertificate)
        {
            var id = Guid.NewGuid();
            var secElement = document.Descendants(securityWSNs + "Security").Single();
            secElement.Add(new XElement(
                securityWSNs + "BinarySecurityToken",
                new XAttribute(securityUtilNs + "Id", $"SecurityToken-{id}"),
                new XAttribute("ValueType", ValueType),
                new XAttribute("EncodingType", EncodingType),
                Convert.ToBase64String(signingCertificate.GetRawCertData())));
            return id;
        }

        /// <summary>
        /// Adds a Timestamp element to the header element.
        /// </summary>
        /// <param name="document">The document whose Header should have a timestamp element added.</param>
        private void AddTimeStamp(XDocument document)
        {
            var secElement = document.Descendants(securityWSNs + "Security").Single();
            var created = $"{DateTime.UtcNow:O}".Substring(0, 23) + "Z";
            var expires = $"{DateTime.UtcNow.AddMinutes(5):O}".Substring(0, 23) + "Z";
            secElement.Add(new XElement(
                securityUtilNs + "Timestamp",
                new XAttribute(securityUtilNs + "Id", $"TimestampRef"),
                new XElement(securityUtilNs + "Created", created),
                new XElement(securityUtilNs + "Expires", expires)));
        }

        /// <summary>
        /// Adds a 'Security' element to the SOAP Header element.
        /// </summary>
        /// <param name="document">The document to add the Security element to.</param>
        private void AddSecurityElement(XDocument document)
        {
            var header = document.Descendants(soapenvNs + "Header").Single();
            header.Add(
                new XElement(
                    securityWSNs + "Security",
                    new XAttribute(new XAttribute(soapenvNs + "mustUnderstand", "1")),
                    new XAttribute(XNamespace.Xmlns + "o", securityWSNs)));
        }
    }
}