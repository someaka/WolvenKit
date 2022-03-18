
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetWaitForUnequipEvents : CombatGadgetTransitions
	{
		public CombatGadgetWaitForUnequipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
