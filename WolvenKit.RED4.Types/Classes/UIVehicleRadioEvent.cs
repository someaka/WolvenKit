
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIVehicleRadioEvent : redEvent
	{
		public UIVehicleRadioEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
