
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTriggerNotifier_QuestInstance : worldITriggerAreaNotiferInstance
	{
		public questTriggerNotifier_QuestInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
