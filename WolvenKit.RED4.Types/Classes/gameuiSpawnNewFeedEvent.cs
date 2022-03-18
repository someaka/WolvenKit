
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSpawnNewFeedEvent : redEvent
	{
		public gameuiSpawnNewFeedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
