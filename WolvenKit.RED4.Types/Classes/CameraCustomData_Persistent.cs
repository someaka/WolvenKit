
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraCustomData_Persistent : ICameraStorageCustomData
	{
		public CameraCustomData_Persistent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
