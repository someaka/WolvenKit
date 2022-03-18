
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LookatCombatTarget_WithoutArms : AIGenericEntityLookatTask
	{
		public LookatCombatTarget_WithoutArms()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
