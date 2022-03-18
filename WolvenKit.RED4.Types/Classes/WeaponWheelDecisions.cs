
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponWheelDecisions : QuickSlotsHoldDecisions
	{
		public WeaponWheelDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
