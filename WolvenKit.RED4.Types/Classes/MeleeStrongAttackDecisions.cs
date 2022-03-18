
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeStrongAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeStrongAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
