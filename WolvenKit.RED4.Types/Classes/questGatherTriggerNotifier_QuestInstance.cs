
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGatherTriggerNotifier_QuestInstance : questTriggerNotifier_QuestInstance
	{
		public questGatherTriggerNotifier_QuestInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
