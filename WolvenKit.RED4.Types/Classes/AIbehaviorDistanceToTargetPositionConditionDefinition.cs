
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDistanceToTargetPositionConditionDefinition : AIbehaviorDistanceToTargetConditionDefinition
	{
		public AIbehaviorDistanceToTargetPositionConditionDefinition()
		{
			ComparisonOperator = Enums.EComparisonType.LessOrEqual;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
