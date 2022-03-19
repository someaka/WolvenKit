namespace WolvenKit.RED4.Types;

public partial class LockTakeControlAction : gameScriptableSystemRequest
{
	[Ordinal(0)] 
	[RED("isLocked")] 
	public CBool IsLocked
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public LockTakeControlAction()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
