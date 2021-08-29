using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineConsumableParameterVector : gamestateMachineActionParameterVector
	{
		private CBool _consumed;

		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetProperty(ref _consumed);
			set => SetProperty(ref _consumed, value);
		}
	}
}
