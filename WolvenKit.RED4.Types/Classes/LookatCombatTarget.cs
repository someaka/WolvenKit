
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LookatCombatTarget : AIGenericEntityLookatTask
	{
		public LookatCombatTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
