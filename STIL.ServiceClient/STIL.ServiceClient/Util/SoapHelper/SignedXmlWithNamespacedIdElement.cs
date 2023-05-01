using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("STIL.ServiceClient.Tests")]

namespace STIL.ServiceClient.Util.SoapHelper
{
    /// <summary>
    /// Uses trick found at https://stackoverflow.com/questions/5099156
    /// "The approach we used was to subclass System.Security.Cryptography.Xml.SignedXml class..."
    /// </summary>
    internal class SignedXmlWithNamespacedIdElement : SignedXml
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignedXmlWithNamespacedIdElement"/> class.
        /// </summary>
        /// <param name="document">The document containing one or more elements tagged with an 'Id' attribute</param>
        public SignedXmlWithNamespacedIdElement(XmlDocument document) : base(document) { }

        /// <summary>
        /// Gets the element with an 'Id' attribute with the given <paramref name="id"/> value
        /// </summary>
        /// <param name="document">The document containing the element with the specified id value</param>
        /// <param name="id">The value of the 'Id' attribute</param>
        /// <returns></returns>
        public override XmlElement GetIdElement(XmlDocument document, string id)
        {
            // check to see if it's a standard ID reference
            XmlElement idElem = base.GetIdElement(document, id);
            if (idElem != null)
            {
                return idElem;
            }
            
            // Else look for elements with an 'id' attribute with the given input (id) value
            var idElems = XElement.Parse(document.OuterXml)
                .Descendants()
                .Where(x => x.HasAttributes)
                .Where(x => x.Attributes().Any(a => a.Name.LocalName.ToLower() == "id" && a.Value == id))
                .ToList();
            
            // We expect there to be exactly one such element, otherwise something
            // has gone wrong.
            if (idElems.Count != 1)
            {
                return null;
            }
            
            var doc = new XmlDocument();
            doc.Load(idElems[0].CreateReader());
            return doc.DocumentElement;
        }
    }
}