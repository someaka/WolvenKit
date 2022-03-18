
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VolCloudsCustomData : ICameraStorageCustomData
	{
		public VolCloudsCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
