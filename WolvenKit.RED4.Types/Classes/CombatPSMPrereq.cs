
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatPSMPrereq : PlayerStateMachinePrereq
	{
		public CombatPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
