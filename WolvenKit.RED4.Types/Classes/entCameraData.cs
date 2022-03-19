namespace WolvenKit.RED4.Types;

public partial class entCameraData : RedBaseClass
{
	[Ordinal(0)] 
	[RED("rotation")] 
	public Quaternion Rotation
	{
		get => GetPropertyValue<Quaternion>();
		set => SetPropertyValue<Quaternion>(value);
	}

	public entCameraData()
	{
		Rotation = new() { R = 1.000000F };

		PostConstruct();
	}

	partial void PostConstruct();
}
