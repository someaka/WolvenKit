
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldINodeInstanceRegistry : worldIRuntimeSystem
	{
		public worldINodeInstanceRegistry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
