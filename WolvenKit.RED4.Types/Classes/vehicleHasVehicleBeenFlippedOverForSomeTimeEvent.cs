
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleHasVehicleBeenFlippedOverForSomeTimeEvent : redEvent
	{
		public vehicleHasVehicleBeenFlippedOverForSomeTimeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
