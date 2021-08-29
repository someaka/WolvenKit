using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SHitOperationData : RedBaseClass
	{
		private CBool _isAttackerPlayer;
		private CBool _isAttackerNPC;
		private CBool _bullets;
		private CBool _explosions;
		private CBool _melee;
		private CFloat _healthPercentage;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("isAttackerPlayer")] 
		public CBool IsAttackerPlayer
		{
			get => GetProperty(ref _isAttackerPlayer);
			set => SetProperty(ref _isAttackerPlayer, value);
		}

		[Ordinal(1)] 
		[RED("isAttackerNPC")] 
		public CBool IsAttackerNPC
		{
			get => GetProperty(ref _isAttackerNPC);
			set => SetProperty(ref _isAttackerNPC, value);
		}

		[Ordinal(2)] 
		[RED("bullets")] 
		public CBool Bullets
		{
			get => GetProperty(ref _bullets);
			set => SetProperty(ref _bullets, value);
		}

		[Ordinal(3)] 
		[RED("explosions")] 
		public CBool Explosions
		{
			get => GetProperty(ref _explosions);
			set => SetProperty(ref _explosions, value);
		}

		[Ordinal(4)] 
		[RED("melee")] 
		public CBool Melee
		{
			get => GetProperty(ref _melee);
			set => SetProperty(ref _melee, value);
		}

		[Ordinal(5)] 
		[RED("healthPercentage")] 
		public CFloat HealthPercentage
		{
			get => GetProperty(ref _healthPercentage);
			set => SetProperty(ref _healthPercentage, value);
		}

		[Ordinal(6)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}
	}
}
