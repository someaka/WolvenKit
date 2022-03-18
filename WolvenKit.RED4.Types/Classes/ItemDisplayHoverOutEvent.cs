
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemDisplayHoverOutEvent : redEvent
	{
		public ItemDisplayHoverOutEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
