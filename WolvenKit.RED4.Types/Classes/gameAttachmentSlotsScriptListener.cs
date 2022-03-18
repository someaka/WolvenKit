
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotsScriptListener : gameIAttachmentSlotsListener
	{
		public gameAttachmentSlotsScriptListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
