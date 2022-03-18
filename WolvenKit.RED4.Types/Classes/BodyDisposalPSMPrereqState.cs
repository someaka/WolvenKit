
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BodyDisposalPSMPrereqState : PlayerStateMachinePrereqState
	{
		public BodyDisposalPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
