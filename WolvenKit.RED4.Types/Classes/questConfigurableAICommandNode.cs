
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questConfigurableAICommandNode : questAICommandNodeBase
	{
		public questConfigurableAICommandNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
