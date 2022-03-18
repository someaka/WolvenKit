
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeDoNothingDefinition : AICTreeNodeAtomicDefinition
	{
		public AICTreeNodeDoNothingDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
