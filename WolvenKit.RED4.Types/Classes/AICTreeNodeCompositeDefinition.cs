
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeCompositeDefinition : AICTreeNodeDefinition
	{
		public AICTreeNodeCompositeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
