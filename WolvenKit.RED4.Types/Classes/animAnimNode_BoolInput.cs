namespace WolvenKit.RED4.Types;

public partial class animAnimNode_BoolInput : animAnimNode_BoolValue
{
	[Ordinal(11)] 
	[RED("group")] 
	public CName Group
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	[Ordinal(12)] 
	[RED("name")] 
	public CName Name
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	public animAnimNode_BoolInput()
	{
		Id = 4294967295;

		PostConstruct();
	}

	partial void PostConstruct();
}
