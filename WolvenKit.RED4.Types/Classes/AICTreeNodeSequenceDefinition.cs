
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSequenceDefinition : AICTreeNodeChildrenListDefinition
	{
		public AICTreeNodeSequenceDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
