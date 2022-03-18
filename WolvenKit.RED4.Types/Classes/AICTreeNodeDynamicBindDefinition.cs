
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeDynamicBindDefinition : AICTreeNodeDynamicDefinition
	{
		public AICTreeNodeDynamicBindDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
