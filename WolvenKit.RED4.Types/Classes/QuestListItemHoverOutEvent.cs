
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListItemHoverOutEvent : redEvent
	{
		public QuestListItemHoverOutEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
