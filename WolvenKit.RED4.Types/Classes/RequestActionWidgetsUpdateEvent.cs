
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestActionWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		public RequestActionWidgetsUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
