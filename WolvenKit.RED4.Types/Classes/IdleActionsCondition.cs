
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IdleActionsCondition : AIbehaviorconditionScript
	{
		public IdleActionsCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
