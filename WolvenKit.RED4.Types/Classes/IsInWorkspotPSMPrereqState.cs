
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsInWorkspotPSMPrereqState : PlayerStateMachinePrereqState
	{
		public IsInWorkspotPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
