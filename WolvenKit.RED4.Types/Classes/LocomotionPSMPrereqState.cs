
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionPSMPrereqState : PlayerStateMachinePrereqState
	{
		public LocomotionPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
