using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AreaTypeTransition : RedBaseClass
	{
		private CEnum<ESecurityAreaType> _transitionTo;
		private CInt32 _transitionHour;
		private CEnum<ETransitionMode> _transitionMode;
		private CUInt32 _listenerID;

		[Ordinal(0)] 
		[RED("transitionTo")] 
		public CEnum<ESecurityAreaType> TransitionTo
		{
			get => GetProperty(ref _transitionTo);
			set => SetProperty(ref _transitionTo, value);
		}

		[Ordinal(1)] 
		[RED("transitionHour")] 
		public CInt32 TransitionHour
		{
			get => GetProperty(ref _transitionHour);
			set => SetProperty(ref _transitionHour, value);
		}

		[Ordinal(2)] 
		[RED("transitionMode")] 
		public CEnum<ETransitionMode> TransitionMode
		{
			get => GetProperty(ref _transitionMode);
			set => SetProperty(ref _transitionMode, value);
		}

		[Ordinal(3)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get => GetProperty(ref _listenerID);
			set => SetProperty(ref _listenerID, value);
		}
	}
}
