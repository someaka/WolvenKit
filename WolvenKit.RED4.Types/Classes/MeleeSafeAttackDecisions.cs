
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeSafeAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeSafeAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
