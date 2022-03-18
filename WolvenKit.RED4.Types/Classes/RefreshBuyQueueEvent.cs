
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshBuyQueueEvent : redEvent
	{
		public RefreshBuyQueueEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
