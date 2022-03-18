
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorInstantConditionNodeDefinition : AIbehaviorConditionNodeDefinition
	{
		public AIbehaviorInstantConditionNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
