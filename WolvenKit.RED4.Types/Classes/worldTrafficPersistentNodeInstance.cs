
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficPersistentNodeInstance : worldINodeInstance
	{
		public worldTrafficPersistentNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
