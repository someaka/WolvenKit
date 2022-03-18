
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeActionDefinition : AICTreeExtendableNodeDefinition
	{
		public AICTreeNodeActionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
