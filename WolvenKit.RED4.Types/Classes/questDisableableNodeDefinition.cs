
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDisableableNodeDefinition : questNodeDefinition
	{
		public questDisableableNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
