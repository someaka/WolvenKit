
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectActionRefreshEvent : redEvent
	{
		public gameObjectActionRefreshEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
