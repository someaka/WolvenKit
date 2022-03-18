
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleVehicleStuckEvent : redEvent
	{
		public vehicleVehicleStuckEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
