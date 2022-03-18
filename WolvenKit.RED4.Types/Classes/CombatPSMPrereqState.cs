
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatPSMPrereqState : PlayerStateMachinePrereqState
	{
		public CombatPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
