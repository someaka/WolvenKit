
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIRefreshedEvent : redEvent
	{
		public UIRefreshedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
