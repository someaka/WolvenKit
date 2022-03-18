
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodePlayerControlledDefinition : AICTreeNodeAtomicDefinition
	{
		public AICTreeNodePlayerControlledDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
