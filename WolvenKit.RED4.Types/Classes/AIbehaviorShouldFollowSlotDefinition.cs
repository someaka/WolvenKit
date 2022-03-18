
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorShouldFollowSlotDefinition : AIbehaviorVehicleExpressionDefinition
	{
		public AIbehaviorShouldFollowSlotDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
