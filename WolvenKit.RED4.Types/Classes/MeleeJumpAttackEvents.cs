
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeJumpAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeJumpAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
