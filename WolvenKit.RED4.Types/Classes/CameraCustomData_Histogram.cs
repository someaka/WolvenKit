
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraCustomData_Histogram : ICameraStorageCustomData
	{
		public CameraCustomData_Histogram()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
