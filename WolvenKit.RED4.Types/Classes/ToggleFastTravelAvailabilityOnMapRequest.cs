using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleFastTravelAvailabilityOnMapRequest : gameScriptableSystemRequest
	{
		private CBool _isEnabled;
		private TweakDBID _pointRecord;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(1)] 
		[RED("pointRecord")] 
		public TweakDBID PointRecord
		{
			get => GetProperty(ref _pointRecord);
			set => SetProperty(ref _pointRecord, value);
		}
	}
}
