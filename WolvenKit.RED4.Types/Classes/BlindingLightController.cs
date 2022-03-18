
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlindingLightController : BasicDistractionDeviceController
	{
		public BlindingLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
