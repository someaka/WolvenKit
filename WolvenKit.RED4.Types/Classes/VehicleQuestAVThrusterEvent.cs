namespace WolvenKit.RED4.Types;

public partial class VehicleQuestAVThrusterEvent : redEvent
{
	[Ordinal(0)] 
	[RED("enable")] 
	public CBool Enable
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public VehicleQuestAVThrusterEvent()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
