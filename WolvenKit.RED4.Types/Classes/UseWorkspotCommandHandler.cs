using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UseWorkspotCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outMoveToWorkspot;
		private CHandle<AIArgumentMapping> _outForceEntryAnimName;
		private CHandle<AIArgumentMapping> _outContinueInCombat;

		[Ordinal(1)] 
		[RED("outMoveToWorkspot")] 
		public CHandle<AIArgumentMapping> OutMoveToWorkspot
		{
			get => GetProperty(ref _outMoveToWorkspot);
			set => SetProperty(ref _outMoveToWorkspot, value);
		}

		[Ordinal(2)] 
		[RED("outForceEntryAnimName")] 
		public CHandle<AIArgumentMapping> OutForceEntryAnimName
		{
			get => GetProperty(ref _outForceEntryAnimName);
			set => SetProperty(ref _outForceEntryAnimName, value);
		}

		[Ordinal(3)] 
		[RED("outContinueInCombat")] 
		public CHandle<AIArgumentMapping> OutContinueInCombat
		{
			get => GetProperty(ref _outContinueInCombat);
			set => SetProperty(ref _outContinueInCombat, value);
		}
	}
}
