
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleToggleDoorOpenEvent : redEvent
	{
		public vehicleToggleDoorOpenEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
