
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTreeNodeDefinition : AIbehaviorBehaviorComponentDefinition
	{
		public AIbehaviorTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
