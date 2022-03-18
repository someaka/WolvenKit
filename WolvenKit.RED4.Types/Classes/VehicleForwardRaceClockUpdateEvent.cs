
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleForwardRaceClockUpdateEvent : redEvent
	{
		public VehicleForwardRaceClockUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
