namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The ws hent tilmeldinger response class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class wsHentTilmeldingerResponse
{
    /// <summary>
    /// The resultat field.
    /// </summary>
    private hentTilmeldingerResResultat resultatField;

    /// <summary>
    /// Gets or sets the <see cref="Resultat"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public hentTilmeldingerResResultat Resultat
    {
        get => resultatField;
        set => resultatField = value;
    }
}