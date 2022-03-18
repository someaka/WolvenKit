
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeDefinition : LibTreeINodeDefinition
	{
		public AICTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
