
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEquippedPrereqListener : gameIAttachmentSlotsListener
	{
		public gameEquippedPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
