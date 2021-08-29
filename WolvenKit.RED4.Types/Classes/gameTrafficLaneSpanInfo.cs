using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTrafficLaneSpanInfo : RedBaseClass
	{
		private worldTrafficLaneUID _laneId;
		private CFloat _laneX1;
		private CFloat _laneX2;

		[Ordinal(0)] 
		[RED("laneId")] 
		public worldTrafficLaneUID LaneId
		{
			get => GetProperty(ref _laneId);
			set => SetProperty(ref _laneId, value);
		}

		[Ordinal(1)] 
		[RED("laneX1")] 
		public CFloat LaneX1
		{
			get => GetProperty(ref _laneX1);
			set => SetProperty(ref _laneX1, value);
		}

		[Ordinal(2)] 
		[RED("laneX2")] 
		public CFloat LaneX2
		{
			get => GetProperty(ref _laneX2);
			set => SetProperty(ref _laneX2, value);
		}
	}
}
