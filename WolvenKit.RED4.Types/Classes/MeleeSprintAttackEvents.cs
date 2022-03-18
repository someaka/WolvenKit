
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeSprintAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeSprintAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
