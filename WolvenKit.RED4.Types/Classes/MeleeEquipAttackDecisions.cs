
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeEquipAttackDecisions : MeleeAttackGenericDecisions
	{
		public MeleeEquipAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
