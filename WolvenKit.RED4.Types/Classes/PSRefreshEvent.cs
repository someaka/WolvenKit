
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSRefreshEvent : redEvent
	{
		public PSRefreshEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
