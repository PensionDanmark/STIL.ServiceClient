using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The skole fag pa hold udliciteret til class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skoleFagPaHoldUdliciteretTil
{
    /// <summary>
    /// The rnr field.
    /// </summary>
    private string cVRnrField;

    /// <summary>
    /// The pnummer field.
    /// </summary>
    private string pnummerField;

    /// <summary>
    /// Gets or sets the <see cref="CVRnr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string CVRnr
    {
        get => cVRnrField;
        set => cVRnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Pnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Pnummer
    {
        get => pnummerField;
        set => pnummerField = value;
    }
}