namespace WolvenKit.RED4.Types;

public partial class SimpleCanUseAvoidLOSMovement : AIbehaviorconditionScript
{
	[Ordinal(0)] 
	[RED("initialized")] 
	public CBool Initialized
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	[Ordinal(1)] 
	[RED("result")] 
	public CBool Result
	{
		get => GetPropertyValue<CBool>();
		set => SetPropertyValue<CBool>(value);
	}

	public SimpleCanUseAvoidLOSMovement()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
