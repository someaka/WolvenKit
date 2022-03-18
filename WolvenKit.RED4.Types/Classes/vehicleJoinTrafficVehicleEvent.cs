
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleJoinTrafficVehicleEvent : redEvent
	{
		public vehicleJoinTrafficVehicleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
