
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetUnequipEvents : CombatGadgetTransitions
	{
		public CombatGadgetUnequipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
