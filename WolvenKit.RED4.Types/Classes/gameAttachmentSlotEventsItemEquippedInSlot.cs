
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotEventsItemEquippedInSlot : gameAttachmentSlotEventsAttachmentSlotEvent
	{
		public gameAttachmentSlotEventsItemEquippedInSlot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
