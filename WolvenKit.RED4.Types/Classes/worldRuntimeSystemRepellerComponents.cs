
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemRepellerComponents : worldIRuntimeSystem
	{
		public worldRuntimeSystemRepellerComponents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
