
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestComputerMainMenuWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		public RequestComputerMainMenuWidgetsUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
