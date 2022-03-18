
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleReadyInteractionDelayEvent : redEvent
	{
		public VehicleReadyInteractionDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
