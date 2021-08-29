using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TemporalPrereqDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private CWeakHandle<TemporalPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<TemporalPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
