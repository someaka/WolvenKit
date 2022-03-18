
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponWheelEvents : QuickSlotsHoldEvents
	{
		public WeaponWheelEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
