
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemTriggers : worldIRuntimeSystem
	{
		public worldRuntimeSystemTriggers()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
