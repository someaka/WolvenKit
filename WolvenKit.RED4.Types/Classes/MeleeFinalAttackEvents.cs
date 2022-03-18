
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeFinalAttackEvents : MeleeAttackGenericEvents
	{
		public MeleeFinalAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
