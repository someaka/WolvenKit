using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISignalCondition : AIbehaviorconditionScript
	{
		private CArray<CEnum<AISignalFlags>> _requiredFlags;
		private CBool _consumesSignal;
		private CBool _activated;
		private AIGateSignal _executingSignal;
		private CUInt32 _executingSignalId;

		[Ordinal(0)] 
		[RED("requiredFlags")] 
		public CArray<CEnum<AISignalFlags>> RequiredFlags
		{
			get => GetProperty(ref _requiredFlags);
			set => SetProperty(ref _requiredFlags, value);
		}

		[Ordinal(1)] 
		[RED("consumesSignal")] 
		public CBool ConsumesSignal
		{
			get => GetProperty(ref _consumesSignal);
			set => SetProperty(ref _consumesSignal, value);
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetProperty(ref _activated);
			set => SetProperty(ref _activated, value);
		}

		[Ordinal(3)] 
		[RED("executingSignal")] 
		public AIGateSignal ExecutingSignal
		{
			get => GetProperty(ref _executingSignal);
			set => SetProperty(ref _executingSignal, value);
		}

		[Ordinal(4)] 
		[RED("executingSignalId")] 
		public CUInt32 ExecutingSignalId
		{
			get => GetProperty(ref _executingSignalId);
			set => SetProperty(ref _executingSignalId, value);
		}
	}
}
