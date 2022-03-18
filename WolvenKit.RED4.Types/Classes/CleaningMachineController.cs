
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CleaningMachineController : BasicDistractionDeviceController
	{
		public CleaningMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
