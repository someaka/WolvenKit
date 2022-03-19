namespace WolvenKit.RED4.Types;

public partial class DelayHackedEvent : redEvent
{
	[Ordinal(0)] 
	[RED("itemID")] 
	public gameItemID ItemID
	{
		get => GetPropertyValue<gameItemID>();
		set => SetPropertyValue<gameItemID>(value);
	}

	public DelayHackedEvent()
	{
		ItemID = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
