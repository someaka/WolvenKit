
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerPanicDrivingEvent : redEvent
	{
		public TriggerPanicDrivingEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
