
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorClearActiveNodesDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		public AIbehaviorClearActiveNodesDebuggerCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
