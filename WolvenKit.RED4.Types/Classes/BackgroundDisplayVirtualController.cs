
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BackgroundDisplayVirtualController : inkVirtualCompoundBackgroundController
	{
		public BackgroundDisplayVirtualController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
