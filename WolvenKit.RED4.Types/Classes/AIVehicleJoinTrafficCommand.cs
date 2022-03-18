
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIVehicleJoinTrafficCommand : AIVehicleCommand
	{
		public AIVehicleJoinTrafficCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
