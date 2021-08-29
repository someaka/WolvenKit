using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTarotCardAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		private CName _imagePart;
		private CString _cardName;
		private CName _animation;

		[Ordinal(5)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetProperty(ref _imagePart);
			set => SetProperty(ref _imagePart, value);
		}

		[Ordinal(6)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetProperty(ref _cardName);
			set => SetProperty(ref _cardName, value);
		}

		[Ordinal(7)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}
	}
}
