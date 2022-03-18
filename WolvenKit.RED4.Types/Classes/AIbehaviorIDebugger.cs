
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIDebugger : ISerializable
	{
		public AIbehaviorIDebugger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
