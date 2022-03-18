
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITreeNodeDeathDefinition : AICTreeNodeActionDefinition
	{
		public AITreeNodeDeathDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
