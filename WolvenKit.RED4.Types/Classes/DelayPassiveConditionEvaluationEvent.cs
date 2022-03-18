
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayPassiveConditionEvaluationEvent : redEvent
	{
		public DelayPassiveConditionEvaluationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
