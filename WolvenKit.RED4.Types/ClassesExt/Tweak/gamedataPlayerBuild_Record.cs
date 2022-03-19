
namespace WolvenKit.RED4.Types;

public partial class gamedataPlayerBuild_Record
{
    [RED("captionIcon")]
    [REDProperty(IsIgnored = true)]
    public TweakDBID CaptionIcon
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }
		
    [RED("displayName")]
    [REDProperty(IsIgnored = true)]
    public gamedataLocKeyWrapper DisplayName
    {
        get => GetPropertyValue<gamedataLocKeyWrapper>();
        set => SetPropertyValue<gamedataLocKeyWrapper>(value);
    }
		
    [RED("enumComment")]
    [REDProperty(IsIgnored = true)]
    public CString EnumComment
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
		
    [RED("enumName")]
    [REDProperty(IsIgnored = true)]
    public CName EnumName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
		
    [RED("proficiencies")]
    [REDProperty(IsIgnored = true)]
    public CArray<TweakDBID> Proficiencies
    {
        get => GetPropertyValue<CArray<TweakDBID>>();
        set => SetPropertyValue<CArray<TweakDBID>>(value);
    }
}