namespace WolvenKit.RED4.Types;

public partial class InterestingFacts : RedBaseClass
{
	[Ordinal(0)] 
	[RED("zone")] 
	public CName Zone
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	public InterestingFacts()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
