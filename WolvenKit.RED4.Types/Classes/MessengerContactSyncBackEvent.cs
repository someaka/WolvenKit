
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessengerContactSyncBackEvent : redEvent
	{
		public MessengerContactSyncBackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
