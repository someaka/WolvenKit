
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeForcedBehaviourDefinition : AICTreeNodeDynamicDefinition
	{
		public AICTreeNodeForcedBehaviourDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
