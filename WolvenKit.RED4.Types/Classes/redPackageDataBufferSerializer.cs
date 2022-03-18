
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redPackageDataBufferSerializer : redPackageCustomTypeSerializer
	{
		public redPackageDataBufferSerializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
