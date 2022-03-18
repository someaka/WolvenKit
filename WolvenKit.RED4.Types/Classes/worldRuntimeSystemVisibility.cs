
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemVisibility : worldIRuntimeSystem
	{
		public worldRuntimeSystemVisibility()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
