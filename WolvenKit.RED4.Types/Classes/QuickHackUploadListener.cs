
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackUploadListener : ActionUploadListener
	{
		public QuickHackUploadListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
