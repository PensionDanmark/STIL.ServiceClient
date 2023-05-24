using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The uddannelsestype type enum.
/// </summary>
[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum UddannelsestypeType
{
    /// <summary>
    /// The auud uddannelsestype type.
    /// </summary>
    AUUD,

    /// <summary>
    /// The fkb uddannelsestype type.
    /// </summary>
    FKB,

    /// <summary>
    /// The amu uddannelsestype type.
    /// </summary>
    AMU,

    /// <summary>
    /// The fuud uddannelsestype type.
    /// </summary>
    FUUD,

    /// <summary>
    /// The åu uddannelsestype type.
    /// </summary>
    ÅU,

    /// <summary>
    /// The ord uddannelsestype type.
    /// </summary>
    ORD,

    /// <summary>
    /// The fu uddannelsestype type.
    /// </summary>
    FU,

    /// <summary>
    /// The afvu uddannelsestype type.
    /// </summary>
    AFVU,

    /// <summary>
    /// The hfe uddannelsestype type.
    /// </summary>
    HFE,
}