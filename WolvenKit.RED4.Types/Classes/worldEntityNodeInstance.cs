
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEntityNodeInstance : worldINodeInstance
	{
		public worldEntityNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
