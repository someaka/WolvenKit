
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleePSMPrereqState : PlayerStateMachinePrereqState
	{
		public MeleePSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
