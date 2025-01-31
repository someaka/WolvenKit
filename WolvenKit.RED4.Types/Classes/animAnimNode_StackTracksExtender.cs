using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_StackTracksExtender : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("newTracks")] 
		public CArray<animFloatTrackInfo> NewTracks
		{
			get => GetPropertyValue<CArray<animFloatTrackInfo>>();
			set => SetPropertyValue<CArray<animFloatTrackInfo>>(value);
		}

		public animAnimNode_StackTracksExtender()
		{
			Id = 4294967295;
			InputLink = new();
			NewTracks = new();
		}
	}
}
