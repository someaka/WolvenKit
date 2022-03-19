namespace WolvenKit.RED4.Types;

public partial class EmitterDelaySettings : RedBaseClass
{
	[Ordinal(0)] 
	[RED("emitterDelay")] 
	public CFloat EmitterDelay
	{
		get => GetPropertyValue<CFloat>();
		set => SetPropertyValue<CFloat>(value);
	}

	[Ordinal(1)] 
	[RED("emitterDelayLow")] 
	public CFloat EmitterDelayLow
	{
		get => GetPropertyValue<CFloat>();
		set => SetPropertyValue<CFloat>(value);
	}

	[Ordinal(2)] 
	[RED("useEmitterDelayRange")] 
	public CBool UseEmitterDelayRange
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	[Ordinal(3)] 
	[RED("useEmitterDelayOnce")] 
	public CBool UseEmitterDelayOnce
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public EmitterDelaySettings()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
