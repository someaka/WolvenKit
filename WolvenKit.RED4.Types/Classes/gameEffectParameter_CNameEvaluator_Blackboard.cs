using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectParameter_CNameEvaluator_Blackboard : gameIEffectParameter_CNameEvaluator
	{
		private gameBlackboardPropertyBindingDefinition _blackboardProperty;

		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetProperty(ref _blackboardProperty);
			set => SetProperty(ref _blackboardProperty, value);
		}
	}
}
