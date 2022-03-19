namespace WolvenKit.RED4.Types;

public partial class GuardbreakReactionTask : AIHitReactionTask
{
	[Ordinal(4)] 
	[RED("tweakDBPackage")] 
	public TweakDBID TweakDBPackage
	{
		get => GetPropertyValue<TweakDBID>();
		set => SetPropertyValue<TweakDBID>(value);
	}

	public GuardbreakReactionTask()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
