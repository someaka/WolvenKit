
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MainframeController : BaseAnimatedDeviceController
	{
		public MainframeController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
