
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetEquipEvents : CombatGadgetTransitions
	{
		public CombatGadgetEquipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
