
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSocketNodeInstance : worldINodeInstance
	{
		public worldSocketNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
