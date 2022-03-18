
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponVendingMachineController : ScriptableDeviceComponent
	{
		public WeaponVendingMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
