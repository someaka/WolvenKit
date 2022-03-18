
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetInactiveDecisions : CombatGadgetTransitions
	{
		public CombatGadgetInactiveDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
