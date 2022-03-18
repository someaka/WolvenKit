
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeJumpAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeJumpAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
