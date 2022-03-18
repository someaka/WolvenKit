
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameOnInventoryEmptyEvent : redEvent
	{
		public gameOnInventoryEmptyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
