
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryChangedEvent : redEvent
	{
		public gameInventoryChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
