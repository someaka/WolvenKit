
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedUIRefreshEvent : redEvent
	{
		public DelayedUIRefreshEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
