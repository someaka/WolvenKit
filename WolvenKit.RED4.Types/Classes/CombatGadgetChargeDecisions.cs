
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetChargeDecisions : CombatGadgetTransitions
	{
		public CombatGadgetChargeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
