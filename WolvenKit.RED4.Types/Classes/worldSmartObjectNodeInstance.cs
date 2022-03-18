
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSmartObjectNodeInstance : worldINodeInstance
	{
		public worldSmartObjectNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
