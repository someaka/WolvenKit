namespace WolvenKit.RED4.Types;

public partial class BuyItemFromVendor : ActionBool
{
	[Ordinal(25)] 
	[RED("itemID")] 
	public gameItemID ItemID
	{
		get => GetPropertyValue<gameItemID>();
		set => SetPropertyValue<gameItemID>(value);
	}

	public BuyItemFromVendor()
	{
		RequesterID = new();
		InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
		ActionWidgetPackage = new() { DependendActions = new() };
		CanTriggerStim = true;
		ItemID = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
