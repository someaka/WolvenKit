
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SurveillanceSystemController : DeviceSystemBaseController
	{
		public SurveillanceSystemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
