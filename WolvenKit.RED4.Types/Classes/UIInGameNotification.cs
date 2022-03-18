
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIInGameNotification : GenericNotificationController
	{
		public UIInGameNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
