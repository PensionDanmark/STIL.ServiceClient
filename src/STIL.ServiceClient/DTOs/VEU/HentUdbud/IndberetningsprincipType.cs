using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The indberetningsprincip type enum.
/// </summary>
[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum IndberetningsprincipType
{
    /// <summary>
    /// The  indberetningsprincip type
    /// </summary>
    P,

    /// <summary>
    /// The  indberetningsprincip type
    /// </summary>
    S,

    /// <summary>
    /// The sfi indberetningsprincip type
    /// </summary>
    SFI,

    /// <summary>
    /// The aav indberetningsprincip type
    /// </summary>
    AAV,

    /// <summary>
    /// The andet indberetningsprincip type
    /// </summary>
    ANDET,
}