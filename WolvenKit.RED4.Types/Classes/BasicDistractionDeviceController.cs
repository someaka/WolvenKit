
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasicDistractionDeviceController : ScriptableDeviceComponent
	{
		public BasicDistractionDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
