
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redPackageCustomTypeSerializer : RedBaseClass
	{
		public redPackageCustomTypeSerializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
