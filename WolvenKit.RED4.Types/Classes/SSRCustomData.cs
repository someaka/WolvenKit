
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SSRCustomData : ICameraStorageCustomData
	{
		public SSRCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
