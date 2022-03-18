
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BodyCarryingPSMPrereqState : PlayerStateMachinePrereqState
	{
		public BodyCarryingPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
