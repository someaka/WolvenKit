
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AuthorisationNotification : GenericNotificationController
	{
		public AuthorisationNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
