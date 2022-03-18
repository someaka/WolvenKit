
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeComboAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeComboAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
