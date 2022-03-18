
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemEventsRemoveActiveItem : redEvent
	{
		public gameItemEventsRemoveActiveItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
