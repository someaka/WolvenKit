
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestObjectiveHoverOutEvent : redEvent
	{
		public QuestObjectiveHoverOutEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
