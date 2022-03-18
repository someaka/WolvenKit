
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardSyncBackEvent : redEvent
	{
		public ShardSyncBackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
