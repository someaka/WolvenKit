
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TeleportToLinkedPortalEvent : redEvent
	{
		public TeleportToLinkedPortalEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
