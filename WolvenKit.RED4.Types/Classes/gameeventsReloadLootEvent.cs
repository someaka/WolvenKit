
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsReloadLootEvent : redEvent
	{
		public gameeventsReloadLootEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
