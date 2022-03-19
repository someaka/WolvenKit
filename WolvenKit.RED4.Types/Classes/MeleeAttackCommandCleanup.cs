namespace WolvenKit.RED4.Types;

public partial class MeleeAttackCommandCleanup : AIbehaviortaskScript
{
	[Ordinal(0)] 
	[RED("inCommand")] 
	public CHandle<AIArgumentMapping> InCommand
	{
		get => GetPropertyValue<CHandle<AIArgumentMapping>>();
		set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
	}

	public MeleeAttackCommandCleanup()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
