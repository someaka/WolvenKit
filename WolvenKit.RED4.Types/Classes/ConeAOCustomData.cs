
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConeAOCustomData : ICameraStorageCustomData
	{
		public ConeAOCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
