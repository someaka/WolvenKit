using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamegpsSettings : RedBaseClass
	{
		private CResourceAsyncReference<worldEffect> _lineEffectOnFoot;
		private CResourceAsyncReference<worldEffect> _lineEffectVehicle;
		private Vector3 _fixedPathOffset;
		private Vector3 _fixedPortalMappinOffset;
		private CFloat _pathRefreshTimeInterval;
		private CFloat _lastPlayerNavmeshPositionRefreshTimeIntervalSecs;
		private CFloat _maxPathDisplayLength;

		[Ordinal(0)] 
		[RED("lineEffectOnFoot")] 
		public CResourceAsyncReference<worldEffect> LineEffectOnFoot
		{
			get => GetProperty(ref _lineEffectOnFoot);
			set => SetProperty(ref _lineEffectOnFoot, value);
		}

		[Ordinal(1)] 
		[RED("lineEffectVehicle")] 
		public CResourceAsyncReference<worldEffect> LineEffectVehicle
		{
			get => GetProperty(ref _lineEffectVehicle);
			set => SetProperty(ref _lineEffectVehicle, value);
		}

		[Ordinal(2)] 
		[RED("fixedPathOffset")] 
		public Vector3 FixedPathOffset
		{
			get => GetProperty(ref _fixedPathOffset);
			set => SetProperty(ref _fixedPathOffset, value);
		}

		[Ordinal(3)] 
		[RED("fixedPortalMappinOffset")] 
		public Vector3 FixedPortalMappinOffset
		{
			get => GetProperty(ref _fixedPortalMappinOffset);
			set => SetProperty(ref _fixedPortalMappinOffset, value);
		}

		[Ordinal(4)] 
		[RED("pathRefreshTimeInterval")] 
		public CFloat PathRefreshTimeInterval
		{
			get => GetProperty(ref _pathRefreshTimeInterval);
			set => SetProperty(ref _pathRefreshTimeInterval, value);
		}

		[Ordinal(5)] 
		[RED("lastPlayerNavmeshPositionRefreshTimeIntervalSecs")] 
		public CFloat LastPlayerNavmeshPositionRefreshTimeIntervalSecs
		{
			get => GetProperty(ref _lastPlayerNavmeshPositionRefreshTimeIntervalSecs);
			set => SetProperty(ref _lastPlayerNavmeshPositionRefreshTimeIntervalSecs, value);
		}

		[Ordinal(6)] 
		[RED("maxPathDisplayLength")] 
		public CFloat MaxPathDisplayLength
		{
			get => GetProperty(ref _maxPathDisplayLength);
			set => SetProperty(ref _maxPathDisplayLength, value);
		}
	}
}
