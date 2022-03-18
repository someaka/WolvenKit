
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemEventsUnequipStarted : redEvent
	{
		public gameItemEventsUnequipStarted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
