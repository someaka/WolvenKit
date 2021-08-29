using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceShootCommandHandler : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private CWeakHandle<AIForceShootCommand> _currentCommand;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public CWeakHandle<AIForceShootCommand> CurrentCommand
		{
			get => GetProperty(ref _currentCommand);
			set => SetProperty(ref _currentCommand, value);
		}
	}
}
