
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleInsideWheelDecisions : QuickSlotsHoldDecisions
	{
		public VehicleInsideWheelDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
