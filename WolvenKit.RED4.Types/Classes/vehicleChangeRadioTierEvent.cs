
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChangeRadioTierEvent : redEvent
	{
		public vehicleChangeRadioTierEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
