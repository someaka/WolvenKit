
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemNavigation : worldIRuntimeSystem
	{
		public worldRuntimeSystemNavigation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
