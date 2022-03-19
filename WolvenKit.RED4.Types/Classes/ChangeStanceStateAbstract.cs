namespace WolvenKit.RED4.Types;

public partial class ChangeStanceStateAbstract : AIbehaviortaskScript
{
	[Ordinal(0)] 
	[RED("changeStateOnDeactivate")] 
	public CBool ChangeStateOnDeactivate
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public ChangeStanceStateAbstract()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
