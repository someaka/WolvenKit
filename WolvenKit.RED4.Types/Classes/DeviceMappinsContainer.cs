using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceMappinsContainer : IScriptable
	{
		private CArray<SDeviceMappinData> _mappins;
		private SDeviceMappinData _newNewFocusMappin;
		private CBool _useNewFocusMappin;
		private CFloat _offsetValue;

		[Ordinal(0)] 
		[RED("mappins")] 
		public CArray<SDeviceMappinData> Mappins
		{
			get => GetProperty(ref _mappins);
			set => SetProperty(ref _mappins, value);
		}

		[Ordinal(1)] 
		[RED("newNewFocusMappin")] 
		public SDeviceMappinData NewNewFocusMappin
		{
			get => GetProperty(ref _newNewFocusMappin);
			set => SetProperty(ref _newNewFocusMappin, value);
		}

		[Ordinal(2)] 
		[RED("useNewFocusMappin")] 
		public CBool UseNewFocusMappin
		{
			get => GetProperty(ref _useNewFocusMappin);
			set => SetProperty(ref _useNewFocusMappin, value);
		}

		[Ordinal(3)] 
		[RED("offsetValue")] 
		public CFloat OffsetValue
		{
			get => GetProperty(ref _offsetValue);
			set => SetProperty(ref _offsetValue, value);
		}
	}
}
