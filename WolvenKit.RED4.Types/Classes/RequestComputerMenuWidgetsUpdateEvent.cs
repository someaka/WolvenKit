
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestComputerMenuWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		public RequestComputerMenuWidgetsUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
