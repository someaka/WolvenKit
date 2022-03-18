
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimerEvent : redEvent
	{
		public TimerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
