
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemStatus : BaseDeviceStatus
	{
		public SecuritySystemStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
