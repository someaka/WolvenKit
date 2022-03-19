namespace WolvenKit.RED4.Types;

public partial class AIbehaviorCompositeTreeNodeDefinition : AIbehaviorTreeNodeDefinition
{
	[Ordinal(0)] 
	[RED("children")] 
	public CArray<CHandle<AIbehaviorTreeNodeDefinition>> Children
	{
		get => GetPropertyValue<CArray<CHandle<AIbehaviorTreeNodeDefinition>>>();
		set => SetPropertyValue<CArray<CHandle<AIbehaviorTreeNodeDefinition>>>(value);
	}

	public AIbehaviorCompositeTreeNodeDefinition()
	{
		PostConstruct();
	}

	partial void PostConstruct();
}
