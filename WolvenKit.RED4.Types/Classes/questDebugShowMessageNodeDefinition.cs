
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDebugShowMessageNodeDefinition : questDisableableNodeDefinition
	{
		public questDebugShowMessageNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
