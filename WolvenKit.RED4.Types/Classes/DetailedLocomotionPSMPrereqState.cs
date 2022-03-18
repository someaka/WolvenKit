
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DetailedLocomotionPSMPrereqState : PlayerStateMachinePrereqState
	{
		public DetailedLocomotionPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
