
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameOnLootAllEvent : redEvent
	{
		public gameOnLootAllEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
