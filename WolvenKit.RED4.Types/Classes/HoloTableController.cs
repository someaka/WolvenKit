
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoloTableController : MediaDeviceController
	{
		public HoloTableController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
