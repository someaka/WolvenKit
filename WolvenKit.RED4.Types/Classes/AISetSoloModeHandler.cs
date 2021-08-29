using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISetSoloModeHandler : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}
	}
}
