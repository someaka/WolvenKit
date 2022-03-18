
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleInteractionCondition : gameinteractionsInteractionScriptedCondition
	{
		public GrappleInteractionCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
