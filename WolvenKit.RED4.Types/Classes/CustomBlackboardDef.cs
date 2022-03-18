
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomBlackboardDef : gamebbScriptDefinition
	{
		public CustomBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
