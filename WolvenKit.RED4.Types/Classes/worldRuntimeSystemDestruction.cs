
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemDestruction : worldIRuntimeSystem
	{
		public worldRuntimeSystemDestruction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
