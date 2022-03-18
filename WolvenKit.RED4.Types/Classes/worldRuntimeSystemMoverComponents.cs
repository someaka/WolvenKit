
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemMoverComponents : worldIRuntimeSystem
	{
		public worldRuntimeSystemMoverComponents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
