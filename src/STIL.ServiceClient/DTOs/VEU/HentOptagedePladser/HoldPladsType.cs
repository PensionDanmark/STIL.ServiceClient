namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// HoldPladsType.
    /// </summary>
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HoldPladsType
    {
        /// <summary>
        /// The dato field.
        /// </summary>
        private System.DateTime datoField;

        /// <summary>
        /// The optaget antal pladser field.
        /// </summary>
        private decimal optagetAntalPladserField;

        /// <summary>
        /// The optaget antal pladser field specified.
        /// </summary>
        private bool optagetAntalPladserFieldSpecified;

        /// <summary>
        /// Gets or sets the <see cref="Dato"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
        public System.DateTime Dato
        {
            get => datoField;
            set => datoField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="OptagetAntalPladser"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public decimal OptagetAntalPladser
        {
            get => optagetAntalPladserField;
            set => optagetAntalPladserField = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="OptagetAntalPladserSpecified"/> value is set.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool OptagetAntalPladserSpecified
        {
            get => optagetAntalPladserFieldSpecified;
            set => optagetAntalPladserFieldSpecified = value;
        }
    }
}