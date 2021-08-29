using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_CoordinateFromVector : animAnimNode_FloatValue
	{
		private CEnum<animVectorCoordinateType> _vectorCoodrinateType;
		private animVectorLink _input;

		[Ordinal(11)] 
		[RED("vectorCoodrinateType")] 
		public CEnum<animVectorCoordinateType> VectorCoodrinateType
		{
			get => GetProperty(ref _vectorCoodrinateType);
			set => SetProperty(ref _vectorCoodrinateType, value);
		}

		[Ordinal(12)] 
		[RED("input")] 
		public animVectorLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
