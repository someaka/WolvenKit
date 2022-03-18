
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorHasPendingForcedBehaviorConditionDefinition : AIbehaviorConditionDefinition
	{
		public AIbehaviorHasPendingForcedBehaviorConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
