
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FallPSMPrereqState : PlayerStateMachinePrereqState
	{
		public FallPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
