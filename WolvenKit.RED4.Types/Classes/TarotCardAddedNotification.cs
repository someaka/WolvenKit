using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TarotCardAddedNotification : GenericNotificationController
	{
		private inkImageWidgetReference _cardImage;
		private inkTextWidgetReference _cardNameLabel;

		[Ordinal(12)] 
		[RED("cardImage")] 
		public inkImageWidgetReference CardImage
		{
			get => GetProperty(ref _cardImage);
			set => SetProperty(ref _cardImage, value);
		}

		[Ordinal(13)] 
		[RED("cardNameLabel")] 
		public inkTextWidgetReference CardNameLabel
		{
			get => GetProperty(ref _cardNameLabel);
			set => SetProperty(ref _cardNameLabel, value);
		}
	}
}
