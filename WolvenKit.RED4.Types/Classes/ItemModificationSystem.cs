namespace WolvenKit.RED4.Types;

public partial class ItemModificationSystem : gameScriptableSystem
{
	[Ordinal(0)] 
	[RED("blackboard")] 
	public CWeakHandle<gameIBlackboard> Blackboard
	{
		get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
		set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
	}

	public ItemModificationSystem()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
