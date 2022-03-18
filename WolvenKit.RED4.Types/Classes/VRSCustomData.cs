
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VRSCustomData : ICameraStorageCustomData
	{
		public VRSCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
