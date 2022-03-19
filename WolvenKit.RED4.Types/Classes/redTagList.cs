namespace WolvenKit.RED4.Types;

public partial class redTagList : RedBaseClass
{
	[Ordinal(0)] 
	[RED("tags")] 
	public CArray<CName> Tags
	{
		get => GetPropertyValue<CArray<CName>>();
		set => SetPropertyValue<CArray<CName>>(value);
	}

	public redTagList()
	{
		Tags = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
