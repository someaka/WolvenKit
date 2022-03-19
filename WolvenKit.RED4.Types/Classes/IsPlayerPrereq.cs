namespace WolvenKit.RED4.Types;

public partial class IsPlayerPrereq : gameIScriptablePrereq
{
	[Ordinal(0)] 
	[RED("invert")] 
	public CBool Invert
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public IsPlayerPrereq()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
