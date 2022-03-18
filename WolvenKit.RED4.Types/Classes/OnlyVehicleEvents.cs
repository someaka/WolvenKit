
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnlyVehicleEvents : QuickSlotsReadyEvents
	{
		public OnlyVehicleEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
