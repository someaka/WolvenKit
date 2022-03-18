
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleInsideWheelEvents : QuickSlotsHoldEvents
	{
		public VehicleInsideWheelEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
