using System;
using System.Xml;

namespace STIL.ServiceClient.Util.SoapHelper
{
    /// <summary>
    /// Helper class to help catch errors from building a SOAP message.
    /// </summary>
    internal class SoapMessageValidator
    {
        private readonly XmlDocument _xmlDocument;

        /// <summary>
        /// Initializes a new instance of the <see cref="SoapMessageValidator"/> class.
        /// </summary>
        /// <param name="xmlDocument">The completed (unsigned) SOAP message.</param>
        public SoapMessageValidator(XmlDocument xmlDocument)
        {
            _xmlDocument = xmlDocument;
        }
        
        /// <summary>
        /// Validates that the document looks like a SOAP message by inspecting the
        /// Envelope, Header and Security elements.
        /// </summary>
        /// <returns>The Security element of the SOAP Header.</returns>
        public XmlNode FindSecurityElement()
        {
            
            var envelopeNode = FindFirstChildElement(
                _xmlDocument,
                "Envelope",
                "Invalid XML Document",
                "Expected a SOAP envelope as top level element");
            var headerNode = FindFirstChildElement(
                envelopeNode,
                "Header",
                "Envelope element has no content",
                "Expected a 'Header' element as first child of the 'Envelope' element");
            var securityNode = FindFirstChildElement(headerNode,
                "Security",
                "Header element has no security element",
                "Expected a 'Security' element as first child of the 'Header' element");
            
            return securityNode;
        }
        
        /// <summary>
        /// Finds the first child element of the given <see cref="XmlNode"/> parent element.
        /// </summary>
        /// <param name="parentNode">The parent element containing the child.</param>
        /// <param name="childLocalName">The local name of the child element.</param>
        /// <param name="msgIfNull">Error message in case the child node cannot be found.</param>
        /// <param name="msgIfWrongElement">Error message in case the child is of the wrong kind.</param>
        /// <returns>The first child of the <paramref name="parentNode"/> <see cref="XmlNode"/>.</returns>
        private static XmlNode FindFirstChildElement(XmlNode parentNode, string childLocalName, string msgIfNull, string msgIfWrongElement)
        {
            var node = ValidateNode(parentNode);
            var firstChild = ValidateChildNode(node, childLocalName, msgIfNull, msgIfWrongElement);
            return firstChild;
        }

        /// <summary>
        /// Ensure that the given <see cref="XmlNode"/> is not null.
        /// </summary>
        /// <param name="node">The node to check for null</param>
        /// <returns>The guarenteed non-null <see cref="XmlNode"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the given <see cref="XmlNode"/> is null.</exception>
        private static XmlNode ValidateNode(XmlNode node)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            return node;
        }

        /// <summary>
        /// Finds the first child node of the given <paramref name="parentNode"/> <see cref="XmlNode"/>.
        /// </summary>
        /// <param name="parentNode">The node containing the child.</param>
        /// <param name="childLocalName">The local name of the child node.</param>
        /// <param name="msgIfNull">Error message in case the child node is <c>null</c>.</param>
        /// <param name="msgIfWrongElement">Error message in case the child element is not the element expected.</param>
        /// <returns>The first child element of the <paramref name="parentNode"/> <see cref="XmlNode"/>.</returns>
        /// <exception cref="ArgumentException">Thrown if the child node is missing or of the wrong type.</exception>
        private static XmlNode ValidateChildNode(XmlNode parentNode, string childLocalName, string msgIfNull, string msgIfWrongElement)
        {
            var childNode = parentNode.FirstChild;
            if (childNode is null)
            {
                throw new ArgumentException(msgIfNull, nameof(parentNode));
            }

            if (childNode.LocalName != childLocalName)
            {
                throw new ArgumentException(msgIfWrongElement, nameof(parentNode));
            }

            return childNode;
        }



    }
}