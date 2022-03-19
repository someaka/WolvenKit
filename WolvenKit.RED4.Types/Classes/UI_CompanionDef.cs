namespace WolvenKit.RED4.Types;

public partial class UI_CompanionDef : gamebbScriptDefinition
{
	[Ordinal(0)] 
	[RED("flatHeadSpawned")] 
	public gamebbScriptID_Bool FlatHeadSpawned
	{
		get => GetPropertyValue<gamebbScriptID_Bool>();
		set => SetPropertyValue<gamebbScriptID_Bool>(value);
	}

	public UI_CompanionDef()
	{
		FlatHeadSpawned = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
