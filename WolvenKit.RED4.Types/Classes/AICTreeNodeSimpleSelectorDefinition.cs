
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSimpleSelectorDefinition : AICTreeNodeChildrenListDefinition
	{
		public AICTreeNodeSimpleSelectorDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
