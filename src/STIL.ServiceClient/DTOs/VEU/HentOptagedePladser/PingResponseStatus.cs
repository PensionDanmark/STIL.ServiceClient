namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// PingResponseStatus.
    /// </summary>
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public enum PingResponseStatus
    {
        /// <summary>
        /// The up ping response status.
        /// </summary>
        up,

        /// <summary>
        /// The down ping response status.
        /// </summary>
        down,
    }
}