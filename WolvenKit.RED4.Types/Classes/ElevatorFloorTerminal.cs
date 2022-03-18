
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElevatorFloorTerminal : Terminal
	{
		public ElevatorFloorTerminal()
		{
			ControllerTypeName = "ElevatorFloorTerminalController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
