
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsProperlySeenByPlayerEvent : redEvent
	{
		public gameeventsProperlySeenByPlayerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
