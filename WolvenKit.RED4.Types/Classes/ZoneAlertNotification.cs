using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoneAlertNotification : GenericNotificationController
	{
		private CHandle<inkanimProxy> _animation;
		private CHandle<ZoneAlertNotificationViewData> _zone_data;
		private inkTextWidgetReference _zoneLabelText;

		[Ordinal(12)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(13)] 
		[RED("zone_data")] 
		public CHandle<ZoneAlertNotificationViewData> Zone_data
		{
			get => GetProperty(ref _zone_data);
			set => SetProperty(ref _zone_data, value);
		}

		[Ordinal(14)] 
		[RED("ZoneLabelText")] 
		public inkTextWidgetReference ZoneLabelText
		{
			get => GetProperty(ref _zoneLabelText);
			set => SetProperty(ref _zoneLabelText, value);
		}
	}
}
