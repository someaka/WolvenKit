
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSnappableNodeInstance : worldINodeInstance
	{
		public worldSnappableNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
