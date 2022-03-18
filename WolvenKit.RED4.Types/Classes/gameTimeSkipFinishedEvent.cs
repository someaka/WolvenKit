
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTimeSkipFinishedEvent : redEvent
	{
		public gameTimeSkipFinishedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
