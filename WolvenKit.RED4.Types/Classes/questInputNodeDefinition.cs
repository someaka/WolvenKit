
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInputNodeDefinition : questIONodeDefinition
	{
		public questInputNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
