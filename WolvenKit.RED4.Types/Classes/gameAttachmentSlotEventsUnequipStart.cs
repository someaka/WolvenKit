
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotEventsUnequipStart : gameAttachmentSlotEventsAttachmentSlotEvent
	{
		public gameAttachmentSlotEventsUnequipStart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
