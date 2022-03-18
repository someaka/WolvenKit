
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAICommandNodeBase : questSignalStoppingNodeDefinition
	{
		public questAICommandNodeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
