
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RangedWeaponPSMPrereqState : PlayerStateMachinePrereqState
	{
		public RangedWeaponPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
