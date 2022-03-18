
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleToggleRadioReceiverEvent : redEvent
	{
		public vehicleToggleRadioReceiverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
