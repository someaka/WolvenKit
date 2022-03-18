
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCrowdEntityReuseEvent : redEvent
	{
		public gameCrowdEntityReuseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
