namespace WolvenKit.RED4.Types;

public partial class MeleeThrowReloadEvents : MeleeEventsTransition
{
	[Ordinal(1)] 
	[RED("isPlayerAiming")] 
	public CBool IsPlayerAiming
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public MeleeThrowReloadEvents()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
