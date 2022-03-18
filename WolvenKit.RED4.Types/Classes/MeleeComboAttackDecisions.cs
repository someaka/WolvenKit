
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeComboAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeComboAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
