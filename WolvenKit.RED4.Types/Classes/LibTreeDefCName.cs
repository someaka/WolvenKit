namespace WolvenKit.RED4.Types;

public partial class LibTreeDefCName : RedBaseClass
{
	[Ordinal(0)] 
	[RED("variableId")] 
	public CUInt16 VariableId
	{
		get => GetPropertyValue<CUInt16>();
		set => SetPropertyValue<CUInt16>(value);
	}

	[Ordinal(1)] 
	[RED("treeVariable")] 
	public CName TreeVariable
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	[Ordinal(2)] 
	[RED("v")] 
	public CName V
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	public LibTreeDefCName()
	{
		VariableId = 65535;

		PostConstruct();
	}

	partial void PostConstruct();
}
