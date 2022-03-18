
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeDeflectAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeDeflectAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
