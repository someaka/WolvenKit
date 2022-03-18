
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDebugger : AIbehaviorIDebugger
	{
		public AIbehaviorDebugger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
