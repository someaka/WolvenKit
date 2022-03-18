
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownPSMPrereqState : PlayerStateMachinePrereqState
	{
		public TakedownPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
