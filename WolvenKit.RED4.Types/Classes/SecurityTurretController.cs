
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityTurretController : SensorDeviceController
	{
		public SecurityTurretController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
