
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehiclePSMPrereqState : PlayerStateMachinePrereqState
	{
		public VehiclePSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
