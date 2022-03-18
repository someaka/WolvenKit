
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraCustomData_DataMoshing : ICameraStorageCustomData
	{
		public CameraCustomData_DataMoshing()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
