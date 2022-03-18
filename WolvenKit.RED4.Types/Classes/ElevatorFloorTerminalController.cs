
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElevatorFloorTerminalController : TerminalController
	{
		public ElevatorFloorTerminalController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
