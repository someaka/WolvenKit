
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeWeaponPSMPrereqState : PlayerStateMachinePrereqState
	{
		public MeleeWeaponPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
