
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestDeviceWidgetUpdateEvent : RequestWidgetUpdateEvent
	{
		public RequestDeviceWidgetUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
