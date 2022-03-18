
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorLeafTreeNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		public AIbehaviorLeafTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
