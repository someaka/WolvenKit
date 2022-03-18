
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldGINodeInstance : worldINodeInstance
	{
		public worldGINodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
