
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemLootedEvent : redEvent
	{
		public ItemLootedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
