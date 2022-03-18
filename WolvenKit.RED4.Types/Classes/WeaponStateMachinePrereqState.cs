
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponStateMachinePrereqState : gamePrereqState
	{
		public WeaponStateMachinePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
