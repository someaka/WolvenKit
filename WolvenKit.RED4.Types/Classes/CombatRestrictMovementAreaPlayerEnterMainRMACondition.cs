
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatRestrictMovementAreaPlayerEnterMainRMACondition : AICombatGuardAreaScriptCondition
	{
		public CombatRestrictMovementAreaPlayerEnterMainRMACondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
