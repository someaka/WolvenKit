using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIJoinTargetsSquadCommandParams : questScriptedAICommandParams
	{
		private gameEntityReference _targetPuppetRef;

		[Ordinal(0)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetProperty(ref _targetPuppetRef);
			set => SetProperty(ref _targetPuppetRef, value);
		}
	}
}
