
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LootPickupScriptedCondition : gameinteractionsInteractionScriptedCondition
	{
		public LootPickupScriptedCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
