
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSignalStoppingNodeDefinition : questDisableableNodeDefinition
	{
		public questSignalStoppingNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
