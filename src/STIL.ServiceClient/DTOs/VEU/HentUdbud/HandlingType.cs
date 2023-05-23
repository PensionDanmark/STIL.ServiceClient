using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The handling type enum.
/// </summary>
[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum HandlingType
{
    /// <summary>
    /// The opret handling type.
    /// </summary>
    OPRET,

    /// <summary>
    /// The opdater handling type.
    /// </summary>
    OPDATER,

    /// <summary>
    /// The slet handling type.
    /// </summary>
    SLET,
}