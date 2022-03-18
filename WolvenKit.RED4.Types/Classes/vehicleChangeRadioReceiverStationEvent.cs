
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChangeRadioReceiverStationEvent : redEvent
	{
		public vehicleChangeRadioReceiverStationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
