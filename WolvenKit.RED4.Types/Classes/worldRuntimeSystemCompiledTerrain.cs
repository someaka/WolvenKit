
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemCompiledTerrain : worldIRuntimeSystem
	{
		public worldRuntimeSystemCompiledTerrain()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
