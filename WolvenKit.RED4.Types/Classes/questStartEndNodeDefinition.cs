
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStartEndNodeDefinition : questDisableableNodeDefinition
	{
		public questStartEndNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
