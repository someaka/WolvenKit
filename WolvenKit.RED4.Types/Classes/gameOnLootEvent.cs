
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameOnLootEvent : redEvent
	{
		public gameOnLootEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
