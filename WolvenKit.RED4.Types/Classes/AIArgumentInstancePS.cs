namespace WolvenKit.RED4.Types;

public partial class AIArgumentInstancePS : ISerializable
{
	[Ordinal(0)] 
	[RED("name")] 
	public CName Name
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	public AIArgumentInstancePS()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
