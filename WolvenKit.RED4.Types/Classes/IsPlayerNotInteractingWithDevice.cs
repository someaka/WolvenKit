
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerNotInteractingWithDevice : gameinteractionsInteractionScriptedCondition
	{
		public IsPlayerNotInteractingWithDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
