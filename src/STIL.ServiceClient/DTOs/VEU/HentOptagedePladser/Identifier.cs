namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// Identifier.
    /// </summary>
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class Identifier
    {
        /// <summary>
        /// The system name field.
        /// </summary>
        private string systemNameField;

        /// <summary>
        /// The system transaction id field.
        /// </summary>
        private string systemTransactionIDField;

        /// <summary>
        /// Gets or sets the <see cref="SystemName"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SystemName
        {
            get => systemNameField;
            set => systemNameField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="SystemTransactionID"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string SystemTransactionID
        {
            get => systemTransactionIDField;
            set => systemTransactionIDField = value;
        }
    }
}