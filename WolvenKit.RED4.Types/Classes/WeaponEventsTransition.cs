
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponEventsTransition : WeaponTransition
	{
		public WeaponEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
