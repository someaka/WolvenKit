
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEmbeddedGraphNodeDefinition : questSignalStoppingNodeDefinition
	{
		public questEmbeddedGraphNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
