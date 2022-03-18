
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorGetSelectedAgentDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		public AIbehaviorGetSelectedAgentDebuggerCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
