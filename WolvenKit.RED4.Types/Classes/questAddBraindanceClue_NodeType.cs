using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAddBraindanceClue_NodeType : questIUIManagerNodeType
	{
		private CName _clueName;
		private CFloat _startTime;
		private CFloat _endTime;
		private CEnum<gameuiEBraindanceLayer> _layer;

		[Ordinal(0)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetProperty(ref _clueName);
			set => SetProperty(ref _clueName, value);
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(2)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get => GetProperty(ref _endTime);
			set => SetProperty(ref _endTime, value);
		}

		[Ordinal(3)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}
	}
}
