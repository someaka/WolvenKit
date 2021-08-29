using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionMoveToState : gameActionReplicatedState
	{
		private Vector3 _targetPos;
		private CFloat _toleranceRadius;
		private CBool _rotateEntity;
		private CUInt32 _moveStyle;

		[Ordinal(5)] 
		[RED("targetPos")] 
		public Vector3 TargetPos
		{
			get => GetProperty(ref _targetPos);
			set => SetProperty(ref _targetPos, value);
		}

		[Ordinal(6)] 
		[RED("toleranceRadius")] 
		public CFloat ToleranceRadius
		{
			get => GetProperty(ref _toleranceRadius);
			set => SetProperty(ref _toleranceRadius, value);
		}

		[Ordinal(7)] 
		[RED("rotateEntity")] 
		public CBool RotateEntity
		{
			get => GetProperty(ref _rotateEntity);
			set => SetProperty(ref _rotateEntity, value);
		}

		[Ordinal(8)] 
		[RED("moveStyle")] 
		public CUInt32 MoveStyle
		{
			get => GetProperty(ref _moveStyle);
			set => SetProperty(ref _moveStyle, value);
		}
	}
}
