using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVendorPanelData : IScriptable
	{
		private gameVendorData _data;
		private CString _assetsLibrary;
		private CName _rootItemName;

		[Ordinal(0)] 
		[RED("data")] 
		public gameVendorData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("assetsLibrary")] 
		public CString AssetsLibrary
		{
			get => GetProperty(ref _assetsLibrary);
			set => SetProperty(ref _assetsLibrary, value);
		}

		[Ordinal(2)] 
		[RED("rootItemName")] 
		public CName RootItemName
		{
			get => GetProperty(ref _rootItemName);
			set => SetProperty(ref _rootItemName, value);
		}
	}
}
