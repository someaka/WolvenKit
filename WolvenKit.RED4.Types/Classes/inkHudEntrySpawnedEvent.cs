
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkHudEntrySpawnedEvent : redEvent
	{
		public inkHudEntrySpawnedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
