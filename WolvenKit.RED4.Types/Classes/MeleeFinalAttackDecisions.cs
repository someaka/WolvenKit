
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeFinalAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeFinalAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
