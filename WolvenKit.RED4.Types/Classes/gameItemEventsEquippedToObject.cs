
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemEventsEquippedToObject : redEvent
	{
		public gameItemEventsEquippedToObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
