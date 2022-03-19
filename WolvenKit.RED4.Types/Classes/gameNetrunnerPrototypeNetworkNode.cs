namespace WolvenKit.RED4.Types;

public partial class gameNetrunnerPrototypeNetworkNode : gameObject
{
	[Ordinal(35)] 
	[RED("colorIndex")] 
	public CInt8 ColorIndex
	{
		get => GetPropertyValue<CInt8>();
		set => SetPropertyValue<CInt8>(value);
	}

	public gameNetrunnerPrototypeNetworkNode()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
