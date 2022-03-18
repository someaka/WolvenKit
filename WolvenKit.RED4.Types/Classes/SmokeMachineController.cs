
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmokeMachineController : BasicDistractionDeviceController
	{
		public SmokeMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
