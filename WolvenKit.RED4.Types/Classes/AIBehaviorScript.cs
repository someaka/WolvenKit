
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBehaviorScript : IScriptable
	{
		public AIBehaviorScript()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
