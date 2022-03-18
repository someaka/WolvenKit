
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestBannerWidgetUpdateEvent : RequestWidgetUpdateEvent
	{
		public RequestBannerWidgetUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
