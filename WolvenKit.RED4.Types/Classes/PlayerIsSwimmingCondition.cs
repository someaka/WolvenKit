
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerIsSwimmingCondition : gameinteractionsInteractionScriptedCondition
	{
		public PlayerIsSwimmingCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
