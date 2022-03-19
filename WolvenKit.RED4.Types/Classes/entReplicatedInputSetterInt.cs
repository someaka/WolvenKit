namespace WolvenKit.RED4.Types;

public partial class entReplicatedInputSetterInt : entReplicatedInputSetterBase
{
	[Ordinal(2)] 
	[RED("value")] 
	public CInt32 Value
	{
		get => GetPropertyValue<CInt32>();
		set => SetPropertyValue<CInt32>(value);
	}

	public entReplicatedInputSetterInt()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
