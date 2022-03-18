
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeBlockAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeBlockAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
