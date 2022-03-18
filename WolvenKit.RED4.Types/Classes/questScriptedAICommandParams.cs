
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questScriptedAICommandParams : questMiscAICommandNodeParams
	{
		public questScriptedAICommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
