using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace STIL.SoapHelper
{
    /// <summary>
    /// Extension methods for serializing objects to <see cref="XElement"/>s
    /// and <see cref="XElement"/>s to <see cref="XmlElement"/>s.
    /// </summary>
    internal static class XmlSerializationExtensions
    {
        /// <summary>
        /// Serialize an object of type <typeparamref name="T"/> to an <see cref="XElement"/>.
        /// </summary>
        /// <param name="data">The data to se serialized as an <see cref="XElement"/>. The <see cref="XmlSerializer"/>
        /// will be used for serializing the object.</param>
        /// <typeparam name="T">The type of the object to serialize as an <see cref="XElement"/>.</typeparam>
        /// <returns>The serialized object as an <see cref="XElement"/>.</returns>
        public static XElement Serialize<T>(this T data)
        {
            using (var writer = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, data);
                return XElement.Parse(writer.ToString());
            }
        }

        /// <summary>
        /// Converts an <see cref="XElement"/> object to an <see cref="XmlElement"/> element.
        /// </summary>
        /// <param name="element">The element to convert.</param>
        /// <returns>The <see cref="XElement"/> as an <see cref="XmlElement"/>.</returns>
        public static XmlElement ToXmlElement(this XNode element)
        {
            var xmldoc = new XmlDocument();
            xmldoc.Load(element.CreateReader());
            return xmldoc.DocumentElement;
        }
    }
}