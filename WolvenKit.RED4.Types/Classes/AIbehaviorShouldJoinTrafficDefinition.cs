
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorShouldJoinTrafficDefinition : AIbehaviorVehicleExpressionDefinition
	{
		public AIbehaviorShouldJoinTrafficDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
