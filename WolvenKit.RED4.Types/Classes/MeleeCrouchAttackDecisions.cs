
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeCrouchAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeCrouchAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
