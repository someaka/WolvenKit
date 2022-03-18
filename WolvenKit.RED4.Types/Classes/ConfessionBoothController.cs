
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConfessionBoothController : BasicDistractionDeviceController
	{
		public ConfessionBoothController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
