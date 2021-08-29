using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCommandConditionExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CName _commandName;
		private CBool _useInheritance;
		private CBool _isEnqueued;
		private CBool _isExecuting;

		[Ordinal(0)] 
		[RED("commandName")] 
		public CName CommandName
		{
			get => GetProperty(ref _commandName);
			set => SetProperty(ref _commandName, value);
		}

		[Ordinal(1)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get => GetProperty(ref _useInheritance);
			set => SetProperty(ref _useInheritance, value);
		}

		[Ordinal(2)] 
		[RED("isEnqueued")] 
		public CBool IsEnqueued
		{
			get => GetProperty(ref _isEnqueued);
			set => SetProperty(ref _isEnqueued, value);
		}

		[Ordinal(3)] 
		[RED("isExecuting")] 
		public CBool IsExecuting
		{
			get => GetProperty(ref _isExecuting);
			set => SetProperty(ref _isExecuting, value);
		}
	}
}
