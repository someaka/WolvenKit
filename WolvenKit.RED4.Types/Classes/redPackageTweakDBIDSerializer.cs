
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redPackageTweakDBIDSerializer : redPackageCustomTypeSerializer
	{
		public redPackageTweakDBIDSerializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
