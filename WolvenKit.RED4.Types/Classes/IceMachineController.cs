
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IceMachineController : VendingMachineController
	{
		public IceMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
