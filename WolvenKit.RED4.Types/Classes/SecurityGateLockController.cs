
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGateLockController : ScriptableDeviceComponent
	{
		public SecurityGateLockController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
