namespace WolvenKit.RED4.Types;

public partial class AlarmLight : BasicDistractionDevice
{
	[Ordinal(100)] 
	[RED("isGlitching")] 
	public CBool IsGlitching
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public AlarmLight()
	{
		ControllerTypeName = "AlarmLightController";

		PostConstruct();
	}

	partial void PostConstruct();
}
