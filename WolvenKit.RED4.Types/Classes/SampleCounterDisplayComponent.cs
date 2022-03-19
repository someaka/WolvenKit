namespace WolvenKit.RED4.Types;

public partial class SampleCounterDisplayComponent : gameScriptableComponent
{
	[Ordinal(5)] 
	[RED("targetPersistentID")] 
	public gamePersistentID TargetPersistentID
	{
		get => GetPropertyValue<gamePersistentID>();
		set => SetPropertyValue<gamePersistentID>(value);
	}

	public SampleCounterDisplayComponent()
	{
		TargetPersistentID = new();

		PostConstruct();
	}

	partial void PostConstruct();
}
