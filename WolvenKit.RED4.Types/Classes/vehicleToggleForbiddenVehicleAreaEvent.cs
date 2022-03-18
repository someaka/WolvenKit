
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleToggleForbiddenVehicleAreaEvent : redEvent
	{
		public vehicleToggleForbiddenVehicleAreaEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
