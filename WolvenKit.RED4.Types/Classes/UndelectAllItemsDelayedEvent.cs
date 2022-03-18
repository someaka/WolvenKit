
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UndelectAllItemsDelayedEvent : redEvent
	{
		public UndelectAllItemsDelayedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
