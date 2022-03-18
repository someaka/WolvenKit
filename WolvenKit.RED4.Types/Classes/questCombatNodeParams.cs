
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCombatNodeParams : questAICommandParams
	{
		public questCombatNodeParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
