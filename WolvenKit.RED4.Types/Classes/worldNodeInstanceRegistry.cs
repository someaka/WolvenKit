
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNodeInstanceRegistry : worldINodeInstanceRegistry
	{
		public worldNodeInstanceRegistry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
