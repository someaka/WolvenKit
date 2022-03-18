
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeSprintAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeSprintAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
