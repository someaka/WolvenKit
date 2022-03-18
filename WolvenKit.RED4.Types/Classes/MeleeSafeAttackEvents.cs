
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeSafeAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeSafeAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
