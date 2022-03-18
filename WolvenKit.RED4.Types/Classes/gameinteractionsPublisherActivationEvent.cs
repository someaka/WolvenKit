
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsPublisherActivationEvent : gameinteractionsPublisherBaseEvent
	{
		public gameinteractionsPublisherActivationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
