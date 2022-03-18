
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshSellQueueEvent : redEvent
	{
		public RefreshSellQueueEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
