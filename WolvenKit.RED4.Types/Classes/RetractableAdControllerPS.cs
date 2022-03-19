namespace WolvenKit.RED4.Types;

public partial class RetractableAdControllerPS : BaseAnimatedDeviceControllerPS
{
	[Ordinal(109)] 
	[RED("isControlled")] 
	public CBool IsControlled
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public RetractableAdControllerPS()
	{
		DeviceName = "LocKey#196";
		TweakDBRecord = 77179103736;
		TweakDBDescriptionRecord = 127230302630;

		PostConstruct();
	}

	partial void PostConstruct();
}
