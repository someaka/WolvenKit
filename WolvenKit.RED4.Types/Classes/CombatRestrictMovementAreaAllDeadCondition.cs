
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatRestrictMovementAreaAllDeadCondition : AICombatGuardAreaScriptCondition
	{
		public CombatRestrictMovementAreaAllDeadCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
