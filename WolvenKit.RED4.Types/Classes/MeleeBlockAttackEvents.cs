
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeBlockAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeBlockAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
