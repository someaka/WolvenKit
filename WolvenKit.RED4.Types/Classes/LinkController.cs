using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LinkController : inkButtonController
	{
		private CString _linkAddress;
		private HDRColor _defaultColor;
		private HDRColor _hoverColor;
		private HDRColor _iGNORED_COLOR;

		[Ordinal(10)] 
		[RED("linkAddress")] 
		public CString LinkAddress
		{
			get => GetProperty(ref _linkAddress);
			set => SetProperty(ref _linkAddress, value);
		}

		[Ordinal(11)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		[Ordinal(12)] 
		[RED("hoverColor")] 
		public HDRColor HoverColor
		{
			get => GetProperty(ref _hoverColor);
			set => SetProperty(ref _hoverColor, value);
		}

		[Ordinal(13)] 
		[RED("IGNORED_COLOR")] 
		public HDRColor IGNORED_COLOR
		{
			get => GetProperty(ref _iGNORED_COLOR);
			set => SetProperty(ref _iGNORED_COLOR, value);
		}
	}
}
