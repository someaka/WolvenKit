
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BurstEvents : WeaponEventsTransition
	{
		public BurstEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
