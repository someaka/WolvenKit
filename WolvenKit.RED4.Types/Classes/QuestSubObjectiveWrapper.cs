
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestSubObjectiveWrapper : ABaseQuestObjectiveWrapper
	{
		public QuestSubObjectiveWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
