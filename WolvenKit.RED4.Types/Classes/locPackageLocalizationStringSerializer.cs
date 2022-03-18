
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locPackageLocalizationStringSerializer : redPackageCustomTypeSerializer
	{
		public locPackageLocalizationStringSerializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
