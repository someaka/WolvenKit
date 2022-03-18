
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSimpleParameterizedBehavior : AIbehaviorParameterizedBehavior
	{
		public AIbehaviorSimpleParameterizedBehavior()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
