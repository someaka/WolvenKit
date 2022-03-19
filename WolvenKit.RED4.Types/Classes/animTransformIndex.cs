namespace WolvenKit.RED4.Types;

public partial class animTransformIndex : RedBaseClass
{
	[Ordinal(0)] 
	[RED("name")] 
	public CName Name
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	public animTransformIndex()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
