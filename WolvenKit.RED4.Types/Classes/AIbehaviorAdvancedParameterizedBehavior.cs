
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorAdvancedParameterizedBehavior : AIbehaviorParameterizedBehavior
	{
		public AIbehaviorAdvancedParameterizedBehavior()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
