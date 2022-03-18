
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorHasDriverConditionDefinition : AIbehaviorConditionDefinition
	{
		public AIbehaviorHasDriverConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
