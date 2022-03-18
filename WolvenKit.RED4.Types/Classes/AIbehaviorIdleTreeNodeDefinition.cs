
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIdleTreeNodeDefinition : AIbehaviorLeafTreeNodeDefinition
	{
		public AIbehaviorIdleTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
