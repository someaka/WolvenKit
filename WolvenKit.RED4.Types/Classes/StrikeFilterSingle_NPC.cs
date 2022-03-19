namespace WolvenKit.RED4.Types;

public partial class StrikeFilterSingle_NPC : gameEffectObjectSingleFilter_Scripted
{
	[Ordinal(0)] 
	[RED("onlyAlive")] 
	public CBool OnlyAlive
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public StrikeFilterSingle_NPC()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
