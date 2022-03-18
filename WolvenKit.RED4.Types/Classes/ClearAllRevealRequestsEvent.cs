
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearAllRevealRequestsEvent : redEvent
	{
		public ClearAllRevealRequestsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
