
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityTurretStatus : BaseDeviceStatus
	{
		public SecurityTurretStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
