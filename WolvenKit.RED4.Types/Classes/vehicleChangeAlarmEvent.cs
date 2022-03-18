
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChangeAlarmEvent : redEvent
	{
		public vehicleChangeAlarmEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
