
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleRaceClockUpdateEvent : gameTickableEvent
	{
		public VehicleRaceClockUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
