
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldIWorkspotSystem : worldIRuntimeSystem
	{
		public worldIWorkspotSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
