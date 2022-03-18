
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemEventsUnequippedFromObject : redEvent
	{
		public gameItemEventsUnequippedFromObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
