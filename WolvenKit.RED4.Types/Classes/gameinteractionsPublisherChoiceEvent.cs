
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsPublisherChoiceEvent : gameinteractionsPublisherBaseEvent
	{
		public gameinteractionsPublisherChoiceEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
