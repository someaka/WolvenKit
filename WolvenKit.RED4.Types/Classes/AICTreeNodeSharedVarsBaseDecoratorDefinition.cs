
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSharedVarsBaseDecoratorDefinition : AICTreeNodeDecoratorDefinition
	{
		public AICTreeNodeSharedVarsBaseDecoratorDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
