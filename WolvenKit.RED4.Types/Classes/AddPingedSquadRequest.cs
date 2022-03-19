namespace WolvenKit.RED4.Types;

public partial class AddPingedSquadRequest : gameScriptableSystemRequest
{
	[Ordinal(0)] 
	[RED("squadName")] 
	public CName SquadName
	{
		get => GetPropertyValue<CName>();
		set => SetPropertyValue<CName>(value);
	}

	public AddPingedSquadRequest()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
