using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_CurveFloatValue : animAnimNode_FloatValue
	{
		private CLegacySingleChannelCurve<CFloat> _curveData;
		private animFloatLink _argument;

		[Ordinal(11)] 
		[RED("curveData")] 
		public CLegacySingleChannelCurve<CFloat> CurveData
		{
			get => GetProperty(ref _curveData);
			set => SetProperty(ref _curveData, value);
		}

		[Ordinal(12)] 
		[RED("argument")] 
		public animFloatLink Argument
		{
			get => GetProperty(ref _argument);
			set => SetProperty(ref _argument, value);
		}
	}
}
