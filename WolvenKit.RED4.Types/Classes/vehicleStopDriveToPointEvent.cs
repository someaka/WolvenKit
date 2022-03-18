
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleStopDriveToPointEvent : redEvent
	{
		public vehicleStopDriveToPointEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
