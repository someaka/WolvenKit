using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FanResaveData : RedBaseClass
	{
		private CEnum<EAnimationType> _animationType;
		private CBool _rotateClockwise;
		private CBool _randomizeBladesSpeed;
		private CFloat _maxRotationSpeed;
		private CFloat _timeToMaxRotation;

		[Ordinal(0)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(1)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetProperty(ref _rotateClockwise);
			set => SetProperty(ref _rotateClockwise, value);
		}

		[Ordinal(2)] 
		[RED("randomizeBladesSpeed")] 
		public CBool RandomizeBladesSpeed
		{
			get => GetProperty(ref _randomizeBladesSpeed);
			set => SetProperty(ref _randomizeBladesSpeed, value);
		}

		[Ordinal(3)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetProperty(ref _maxRotationSpeed);
			set => SetProperty(ref _maxRotationSpeed, value);
		}

		[Ordinal(4)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetProperty(ref _timeToMaxRotation);
			set => SetProperty(ref _timeToMaxRotation, value);
		}
	}
}
