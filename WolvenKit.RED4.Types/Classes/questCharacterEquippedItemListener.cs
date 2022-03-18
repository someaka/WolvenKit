
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterEquippedItemListener : gameIAttachmentSlotsListener
	{
		public questCharacterEquippedItemListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
