using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCombatNodeParams_LookAtTarget : questCombatNodeParams
	{
		private NodeRef _targetNode;
		private gameEntityReference _targetPuppet;
		private CFloat _duration;
		private CBool _immediately;

		[Ordinal(0)] 
		[RED("targetNode")] 
		public NodeRef TargetNode
		{
			get => GetProperty(ref _targetNode);
			set => SetProperty(ref _targetNode, value);
		}

		[Ordinal(1)] 
		[RED("targetPuppet")] 
		public gameEntityReference TargetPuppet
		{
			get => GetProperty(ref _targetPuppet);
			set => SetProperty(ref _targetPuppet, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetProperty(ref _immediately);
			set => SetProperty(ref _immediately, value);
		}
	}
}
