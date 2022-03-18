
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraCustomData_RenderProxyData : ICameraStorageCustomData
	{
		public CameraCustomData_RenderProxyData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
