
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorWaitConditionDefinition : AIbehaviorConditionDefinition
	{
		public AIbehaviorWaitConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
