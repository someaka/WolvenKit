
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeSkipCursorInitFinishedEvent : redEvent
	{
		public TimeSkipCursorInitFinishedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
