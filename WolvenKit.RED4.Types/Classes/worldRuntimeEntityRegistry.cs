
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeEntityRegistry : worldIRuntimeSystem
	{
		public worldRuntimeEntityRegistry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
