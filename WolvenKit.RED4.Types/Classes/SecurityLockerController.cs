
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityLockerController : ScriptableDeviceComponent
	{
		public SecurityLockerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
