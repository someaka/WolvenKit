
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UINotification : GenericNotificationController
	{
		public UINotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
