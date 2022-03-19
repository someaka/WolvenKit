namespace WolvenKit.RED4.Types;

public partial class NPCInitTask : AIbehaviortaskStackScript
{
	[Ordinal(0)] 
	[RED("preventSkippingDeathAnimation")] 
	public CBool PreventSkippingDeathAnimation
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public NPCInitTask()
	{
		PreventSkippingDeathAnimation = true;

		PostConstruct();
	}

	partial void PostConstruct();
}
