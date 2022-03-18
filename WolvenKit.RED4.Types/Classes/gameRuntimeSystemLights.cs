
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRuntimeSystemLights : worldIRuntimeSystem
	{
		public gameRuntimeSystemLights()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
