
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeAttackGenericDecisions : MeleeTransition
	{
		public MeleeAttackGenericDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
