
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIInGameNotificationRemoveEvent : redEvent
	{
		public UIInGameNotificationRemoveEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
