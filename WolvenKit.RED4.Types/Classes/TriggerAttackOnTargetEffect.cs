using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerAttackOnTargetEffect : gameEffector
	{
		private CBool _isRandom;
		private CFloat _applicationChance;
		private CWeakHandle<gameObject> _owner;
		private TweakDBID _attackTDBID;
		private CHandle<gameAttack_GameEffect> _attack;

		[Ordinal(0)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get => GetProperty(ref _isRandom);
			set => SetProperty(ref _isRandom, value);
		}

		[Ordinal(1)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get => GetProperty(ref _applicationChance);
			set => SetProperty(ref _applicationChance, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetProperty(ref _attackTDBID);
			set => SetProperty(ref _attackTDBID, value);
		}

		[Ordinal(4)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}
	}
}
