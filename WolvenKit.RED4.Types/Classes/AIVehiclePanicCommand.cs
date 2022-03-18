
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIVehiclePanicCommand : AIVehicleCommand
	{
		public AIVehiclePanicCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
