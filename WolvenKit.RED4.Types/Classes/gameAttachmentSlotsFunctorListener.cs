
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotsFunctorListener : gameIAttachmentSlotsListener
	{
		public gameAttachmentSlotsFunctorListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
