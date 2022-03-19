namespace WolvenKit.RED4.Types;

public partial class VehicleQuestSirenEvent : redEvent
{
	[Ordinal(0)] 
	[RED("lights")] 
	public CBool Lights
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	[Ordinal(1)] 
	[RED("sounds")] 
	public CBool Sounds
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public VehicleQuestSirenEvent()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
