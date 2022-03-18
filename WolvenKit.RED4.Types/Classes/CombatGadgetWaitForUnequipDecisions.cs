
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetWaitForUnequipDecisions : CombatGadgetTransitions
	{
		public CombatGadgetWaitForUnequipDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
