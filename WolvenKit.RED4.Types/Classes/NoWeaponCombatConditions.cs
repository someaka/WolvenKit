
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NoWeaponCombatConditions : AIAutonomousConditions
	{
		public NoWeaponCombatConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
