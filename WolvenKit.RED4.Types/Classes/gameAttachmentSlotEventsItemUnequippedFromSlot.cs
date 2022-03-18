
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotEventsItemUnequippedFromSlot : gameAttachmentSlotEventsAttachmentSlotEvent
	{
		public gameAttachmentSlotEventsItemUnequippedFromSlot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
