
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleRadioStationInitialized : redEvent
	{
		public vehicleRadioStationInitialized()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
