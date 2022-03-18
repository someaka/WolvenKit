
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeWeaponPSMPrereq : PlayerStateMachinePrereq
	{
		public MeleeWeaponPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
