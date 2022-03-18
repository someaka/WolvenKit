
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FanController : BasicDistractionDeviceController
	{
		public FanController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
