
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityBreachPuppetNotificationEvent : SecuritySystemInput
	{
		public SecurityBreachPuppetNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
