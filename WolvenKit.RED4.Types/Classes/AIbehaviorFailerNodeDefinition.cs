
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorFailerNodeDefinition : AIbehaviorLeafTreeNodeDefinition
	{
		public AIbehaviorFailerNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
