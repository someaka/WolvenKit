
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPackageNodeRefSerializer : redPackageCustomTypeSerializer
	{
		public worldPackageNodeRefSerializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
