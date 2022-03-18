
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCTreeNodeControlledByQuestNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		public AIbehaviorCTreeNodeControlledByQuestNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
