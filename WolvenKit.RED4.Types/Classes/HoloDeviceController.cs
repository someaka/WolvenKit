
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoloDeviceController : ScriptableDeviceComponent
	{
		public HoloDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
