
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PachinkoMachineController : ArcadeMachineController
	{
		public PachinkoMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
