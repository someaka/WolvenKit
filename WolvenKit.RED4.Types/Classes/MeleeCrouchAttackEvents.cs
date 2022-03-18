
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeCrouchAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeCrouchAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
