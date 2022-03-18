
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IgnoreMoveCommandInCombatCondition : AIbehaviorconditionScript
	{
		public IgnoreMoveCommandInCombatCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
