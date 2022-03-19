
namespace WolvenKit.RED4.Types;

public partial class gamedataInventoryItemGroup_Record
{
    [RED("items")]
    [REDProperty(IsIgnored = true)]
    public CArray<TweakDBID> Items
    {
        get => GetPropertyValue<CArray<TweakDBID>>();
        set => SetPropertyValue<CArray<TweakDBID>>(value);
    }
}