
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RangedWeaponPSMPrereq : PlayerStateMachinePrereq
	{
		public RangedWeaponPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
