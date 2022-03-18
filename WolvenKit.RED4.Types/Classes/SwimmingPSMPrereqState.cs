
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingPSMPrereqState : PlayerStateMachinePrereqState
	{
		public SwimmingPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
