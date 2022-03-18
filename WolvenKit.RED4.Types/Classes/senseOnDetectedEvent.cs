
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseOnDetectedEvent : senseVisibilityEvent
	{
		public senseOnDetectedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
