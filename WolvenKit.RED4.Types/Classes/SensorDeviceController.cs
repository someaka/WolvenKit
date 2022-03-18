
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SensorDeviceController : ExplosiveDeviceController
	{
		public SensorDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
