
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AccessBreachListener : QuickHackUploadListener
	{
		public AccessBreachListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
