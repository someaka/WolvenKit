
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponeventsReloadStartEvent : redEvent
	{
		public gameweaponeventsReloadStartEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
