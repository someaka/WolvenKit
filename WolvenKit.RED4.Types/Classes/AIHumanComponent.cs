using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIHumanComponent : AICAgent
	{
		private TweakDBID _movementParamsRecord;
		private CWeakHandle<gameIBlackboard> _shootingBlackboard;
		private CWeakHandle<gameIBlackboard> _gadgetBlackboard;
		private CWeakHandle<gameIBlackboard> _coverBlackboard;
		private CWeakHandle<gameIBlackboard> _actionBlackboard;
		private CWeakHandle<gameIBlackboard> _patrolBlackboard;
		private CWeakHandle<gameIBlackboard> _alertedPatrolBlackboard;
		private CUInt32 _friendlyFireCheckID;
		private CHandle<gameIFriendlyFireSystem> _ffs;
		private CUInt32 _loSFinderCheckID;
		private CHandle<gameLoSIFinderSystem> _loSFinderSystem;
		private CWeakHandle<senseVisibleObject> _loSFinderVisibleObject;
		private CHandle<ActionAnimationScriptProxy> _actionAnimationScriptProxy;
		private gameDelayID _lastOwnerBlockedAttackEventID;
		private gameDelayID _lastOwnerParriedAttackEventID;
		private gameDelayID _lastOwnerDodgedAttackEventID;
		private CWeakHandle<gameObject> _grenadeThrowQueryTarget;
		private CInt32 _grenadeThrowQueryId;
		private AIbehaviorScriptExecutionContext _scriptContext;
		private CBool _scriptContextInitialized;
		private CHandle<gamedataGameplayAbility_Record> _kerenzikovAbilityRecord;
		private CUInt32 _highLevelCb;
		private AIbehaviorUniqueActiveCommandList _activeCommands;

		[Ordinal(4)] 
		[RED("movementParamsRecord")] 
		public TweakDBID MovementParamsRecord
		{
			get => GetProperty(ref _movementParamsRecord);
			set => SetProperty(ref _movementParamsRecord, value);
		}

		[Ordinal(5)] 
		[RED("shootingBlackboard")] 
		public CWeakHandle<gameIBlackboard> ShootingBlackboard
		{
			get => GetProperty(ref _shootingBlackboard);
			set => SetProperty(ref _shootingBlackboard, value);
		}

		[Ordinal(6)] 
		[RED("gadgetBlackboard")] 
		public CWeakHandle<gameIBlackboard> GadgetBlackboard
		{
			get => GetProperty(ref _gadgetBlackboard);
			set => SetProperty(ref _gadgetBlackboard, value);
		}

		[Ordinal(7)] 
		[RED("coverBlackboard")] 
		public CWeakHandle<gameIBlackboard> CoverBlackboard
		{
			get => GetProperty(ref _coverBlackboard);
			set => SetProperty(ref _coverBlackboard, value);
		}

		[Ordinal(8)] 
		[RED("actionBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActionBlackboard
		{
			get => GetProperty(ref _actionBlackboard);
			set => SetProperty(ref _actionBlackboard, value);
		}

		[Ordinal(9)] 
		[RED("patrolBlackboard")] 
		public CWeakHandle<gameIBlackboard> PatrolBlackboard
		{
			get => GetProperty(ref _patrolBlackboard);
			set => SetProperty(ref _patrolBlackboard, value);
		}

		[Ordinal(10)] 
		[RED("alertedPatrolBlackboard")] 
		public CWeakHandle<gameIBlackboard> AlertedPatrolBlackboard
		{
			get => GetProperty(ref _alertedPatrolBlackboard);
			set => SetProperty(ref _alertedPatrolBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("friendlyFireCheckID")] 
		public CUInt32 FriendlyFireCheckID
		{
			get => GetProperty(ref _friendlyFireCheckID);
			set => SetProperty(ref _friendlyFireCheckID, value);
		}

		[Ordinal(12)] 
		[RED("ffs")] 
		public CHandle<gameIFriendlyFireSystem> Ffs
		{
			get => GetProperty(ref _ffs);
			set => SetProperty(ref _ffs, value);
		}

		[Ordinal(13)] 
		[RED("LoSFinderCheckID")] 
		public CUInt32 LoSFinderCheckID
		{
			get => GetProperty(ref _loSFinderCheckID);
			set => SetProperty(ref _loSFinderCheckID, value);
		}

		[Ordinal(14)] 
		[RED("loSFinderSystem")] 
		public CHandle<gameLoSIFinderSystem> LoSFinderSystem
		{
			get => GetProperty(ref _loSFinderSystem);
			set => SetProperty(ref _loSFinderSystem, value);
		}

		[Ordinal(15)] 
		[RED("LoSFinderVisibleObject")] 
		public CWeakHandle<senseVisibleObject> LoSFinderVisibleObject
		{
			get => GetProperty(ref _loSFinderVisibleObject);
			set => SetProperty(ref _loSFinderVisibleObject, value);
		}

		[Ordinal(16)] 
		[RED("actionAnimationScriptProxy")] 
		public CHandle<ActionAnimationScriptProxy> ActionAnimationScriptProxy
		{
			get => GetProperty(ref _actionAnimationScriptProxy);
			set => SetProperty(ref _actionAnimationScriptProxy, value);
		}

		[Ordinal(17)] 
		[RED("lastOwnerBlockedAttackEventID")] 
		public gameDelayID LastOwnerBlockedAttackEventID
		{
			get => GetProperty(ref _lastOwnerBlockedAttackEventID);
			set => SetProperty(ref _lastOwnerBlockedAttackEventID, value);
		}

		[Ordinal(18)] 
		[RED("lastOwnerParriedAttackEventID")] 
		public gameDelayID LastOwnerParriedAttackEventID
		{
			get => GetProperty(ref _lastOwnerParriedAttackEventID);
			set => SetProperty(ref _lastOwnerParriedAttackEventID, value);
		}

		[Ordinal(19)] 
		[RED("lastOwnerDodgedAttackEventID")] 
		public gameDelayID LastOwnerDodgedAttackEventID
		{
			get => GetProperty(ref _lastOwnerDodgedAttackEventID);
			set => SetProperty(ref _lastOwnerDodgedAttackEventID, value);
		}

		[Ordinal(20)] 
		[RED("grenadeThrowQueryTarget")] 
		public CWeakHandle<gameObject> GrenadeThrowQueryTarget
		{
			get => GetProperty(ref _grenadeThrowQueryTarget);
			set => SetProperty(ref _grenadeThrowQueryTarget, value);
		}

		[Ordinal(21)] 
		[RED("grenadeThrowQueryId")] 
		public CInt32 GrenadeThrowQueryId
		{
			get => GetProperty(ref _grenadeThrowQueryId);
			set => SetProperty(ref _grenadeThrowQueryId, value);
		}

		[Ordinal(22)] 
		[RED("scriptContext")] 
		public AIbehaviorScriptExecutionContext ScriptContext
		{
			get => GetProperty(ref _scriptContext);
			set => SetProperty(ref _scriptContext, value);
		}

		[Ordinal(23)] 
		[RED("scriptContextInitialized")] 
		public CBool ScriptContextInitialized
		{
			get => GetProperty(ref _scriptContextInitialized);
			set => SetProperty(ref _scriptContextInitialized, value);
		}

		[Ordinal(24)] 
		[RED("kerenzikovAbilityRecord")] 
		public CHandle<gamedataGameplayAbility_Record> KerenzikovAbilityRecord
		{
			get => GetProperty(ref _kerenzikovAbilityRecord);
			set => SetProperty(ref _kerenzikovAbilityRecord, value);
		}

		[Ordinal(25)] 
		[RED("highLevelCb")] 
		public CUInt32 HighLevelCb
		{
			get => GetProperty(ref _highLevelCb);
			set => SetProperty(ref _highLevelCb, value);
		}

		[Ordinal(26)] 
		[RED("activeCommands")] 
		public AIbehaviorUniqueActiveCommandList ActiveCommands
		{
			get => GetProperty(ref _activeCommands);
			set => SetProperty(ref _activeCommands, value);
		}
	}
}
