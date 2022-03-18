
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetEquipDecisions : CombatGadgetTransitions
	{
		public CombatGadgetEquipDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
