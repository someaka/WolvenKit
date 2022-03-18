
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeDynamicDefinition : AICTreeNodeDefinition
	{
		public AICTreeNodeDynamicDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
