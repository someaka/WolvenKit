
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RetractableAdController : BaseAnimatedDeviceController
	{
		public RetractableAdController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
