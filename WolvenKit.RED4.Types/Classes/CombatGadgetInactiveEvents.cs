
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetInactiveEvents : CombatGadgetTransitions
	{
		public CombatGadgetInactiveEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
