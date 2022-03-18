
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetTransitions : DefaultTransition
	{
		public CombatGadgetTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
