
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemEnvironment : worldIRuntimeSystem
	{
		public worldRuntimeSystemEnvironment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
