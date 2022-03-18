
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemDebugRendering : worldIRuntimeSystem
	{
		public worldRuntimeSystemDebugRendering()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
