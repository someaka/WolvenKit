namespace WolvenKit.RED4.Types;

public partial class ClothingSetAddedEvent : redEvent
{
	[Ordinal(0)] 
	[RED("clothingSet")] 
	public ClothingSet ClothingSet
	{
		get => GetPropertyValue<ClothingSet>();
		set => SetPropertyValue<ClothingSet>(value);
	}

	[Ordinal(1)] 
	[RED("setID")] 
	public CInt32 SetID
	{
		get => GetPropertyValue<CInt32>();
		set => SetPropertyValue<CInt32>(value);
	}

	public ClothingSetAddedEvent()
	{
		ClothingSet = new() { SetID = -1, ClothingList = new() };

		PostConstruct();
	}

	partial void PostConstruct();
}
