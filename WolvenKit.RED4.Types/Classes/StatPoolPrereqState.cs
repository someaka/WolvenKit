namespace WolvenKit.RED4.Types;

public partial class StatPoolPrereqState : gamePrereqState
{
	[Ordinal(0)] 
	[RED("listener")] 
	public CHandle<BaseStatPoolPrereqListener> Listener
	{
		get => GetPropertyValue<CHandle<BaseStatPoolPrereqListener>>();
		set => SetPropertyValue<CHandle<BaseStatPoolPrereqListener>>(value);
	}

	public StatPoolPrereqState()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
