
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HeadLookatCombatTarget : LookatCombatTarget
	{
		public HeadLookatCombatTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
