
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeDilationPSMPrereqState : PlayerStateMachinePrereqState
	{
		public TimeDilationPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
