
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleWheelEvents : QuickSlotsHoldEvents
	{
		public VehicleWheelEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
