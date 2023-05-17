namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class personoplysningerTilmeldingType
{
    private string arbejderSomField;
    private enumJN loenUnderKursusField;
    private bool loenUnderKursusFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="ArbejderSom"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string ArbejderSom
    {
        get => arbejderSomField;
        set => arbejderSomField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="LoenUnderKursus"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public enumJN LoenUnderKursus
    {
        get => loenUnderKursusField;
        set => loenUnderKursusField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="LoenUnderKursusSpecified"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool LoenUnderKursusSpecified
    {
        get => loenUnderKursusFieldSpecified;
        set => loenUnderKursusFieldSpecified = value;
    }
}