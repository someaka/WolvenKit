
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaterCustomData : ICameraStorageCustomData
	{
		public WaterCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
