using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemOutput : ActionBool
	{
		private CEnum<ESecuritySystemState> _currentSecurityState;
		private CEnum<EBreachOrigin> _breachOrigin;
		private CHandle<SecuritySystemInput> _originalInputEvent;
		private CBool _securityStateChanged;

		[Ordinal(25)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get => GetProperty(ref _currentSecurityState);
			set => SetProperty(ref _currentSecurityState, value);
		}

		[Ordinal(26)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetProperty(ref _breachOrigin);
			set => SetProperty(ref _breachOrigin, value);
		}

		[Ordinal(27)] 
		[RED("originalInputEvent")] 
		public CHandle<SecuritySystemInput> OriginalInputEvent
		{
			get => GetProperty(ref _originalInputEvent);
			set => SetProperty(ref _originalInputEvent, value);
		}

		[Ordinal(28)] 
		[RED("securityStateChanged")] 
		public CBool SecurityStateChanged
		{
			get => GetProperty(ref _securityStateChanged);
			set => SetProperty(ref _securityStateChanged, value);
		}
	}
}
