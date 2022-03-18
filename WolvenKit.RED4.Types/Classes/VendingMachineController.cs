
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingMachineController : ScriptableDeviceComponent
	{
		public VendingMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
