namespace WolvenKit.RED4.Types;

public partial class IsPuppetActivePrereq : gameIScriptablePrereq
{
	[Ordinal(0)] 
	[RED("invert")] 
	public CBool Invert
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public IsPuppetActivePrereq()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
