namespace WolvenKit.RED4.Types;

public partial class gameEffectObjectProvider_PhysicalRayFan : gameEffectObjectProvider_PhysicalRay
{
	[Ordinal(6)] 
	[RED("inputMinRayAngleDiff")] 
	public gameEffectInputParameter_Float InputMinRayAngleDiff
	{
		get => GetPropertyValue<gameEffectInputParameter_Float>();
		set => SetPropertyValue<gameEffectInputParameter_Float>(value);
	}

	public gameEffectObjectProvider_PhysicalRayFan()
	{
		InputMinRayAngleDiff = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
