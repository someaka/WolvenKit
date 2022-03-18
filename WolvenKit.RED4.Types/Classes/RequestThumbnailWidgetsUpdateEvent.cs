
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestThumbnailWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		public RequestThumbnailWidgetsUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
