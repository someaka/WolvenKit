
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeStrongAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeStrongAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
