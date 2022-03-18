
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redPackageRUIDSerializer : redPackageCustomTypeSerializer
	{
		public redPackageRUIDSerializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
