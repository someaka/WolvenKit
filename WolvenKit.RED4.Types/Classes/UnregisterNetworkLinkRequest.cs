using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterNetworkLinkRequest : gameScriptableSystemRequest
	{
		private CArray<SNetworkLinkData> _linksData;

		[Ordinal(0)] 
		[RED("linksData")] 
		public CArray<SNetworkLinkData> LinksData
		{
			get => GetProperty(ref _linksData);
			set => SetProperty(ref _linksData, value);
		}
	}
}
