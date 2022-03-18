
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ContainerStateInteractionCondition : gameinteractionsInteractionScriptedCondition
	{
		public ContainerStateInteractionCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
