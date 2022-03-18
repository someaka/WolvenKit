
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorForcedBehaviorNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		public AIbehaviorForcedBehaviorNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
