using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The ping response status enum.
/// </summary>
[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
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