
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameplayeractionsAttachSlotListener : gameIAttachmentSlotsListener
	{
		public gameplayeractionsAttachSlotListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
