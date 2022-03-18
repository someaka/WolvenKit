
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemScenes : worldIRuntimeSystem
	{
		public worldRuntimeSystemScenes()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
