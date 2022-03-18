
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NoAmmoEvents : WeaponEventsTransition
	{
		public NoAmmoEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
