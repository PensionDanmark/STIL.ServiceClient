using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The undervisningsform type enum.
/// </summary>
[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum UndervisningsformType
{
    /// <summary>
    /// The aftenundervisning undervisningsform type.
    /// </summary>
    Aftenundervisning,

    /// <summary>
    /// The fjernundervisning undervisningsform type.
    /// </summary>
    Fjernundervisning,

    /// <summary>
    /// The dagundervisning undervisningsform type.
    /// </summary>
    Dagundervisning,

    /// <summary>
    /// The weekendundervisning undervisningsform type.
    /// </summary>
    Weekendundervisning,

    /// <summary>
    /// The påfremmedsprog undervisningsform type.
    /// </summary>
    [System.Xml.Serialization.XmlEnumAttribute("På fremmedsprog")]
    Påfremmedsprog,
}