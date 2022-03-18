
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBlackboardDef : gamebbScriptDefinition
	{
		public AIBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
