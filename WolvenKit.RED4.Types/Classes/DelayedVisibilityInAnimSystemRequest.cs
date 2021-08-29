using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		private CHandle<ForcedVisibilityInAnimSystemData> _data;
		private CBool _isVisible;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<ForcedVisibilityInAnimSystemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		[Ordinal(2)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}
	}
}
