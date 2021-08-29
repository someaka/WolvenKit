using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInjectCombatTargetCommand : AICombatRelatedCommand
	{
		private NodeRef _targetNodeRef;
		private gameEntityReference _targetPuppetRef;
		private CFloat _duration;

		[Ordinal(5)] 
		[RED("targetNodeRef")] 
		public NodeRef TargetNodeRef
		{
			get => GetProperty(ref _targetNodeRef);
			set => SetProperty(ref _targetNodeRef, value);
		}

		[Ordinal(6)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetProperty(ref _targetPuppetRef);
			set => SetProperty(ref _targetPuppetRef, value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}
	}
}
