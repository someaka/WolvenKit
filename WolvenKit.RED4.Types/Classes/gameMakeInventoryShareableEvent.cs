
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMakeInventoryShareableEvent : redEvent
	{
		public gameMakeInventoryShareableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
