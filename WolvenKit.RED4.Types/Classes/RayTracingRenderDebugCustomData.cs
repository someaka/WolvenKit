
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RayTracingRenderDebugCustomData : ICameraStorageCustomData
	{
		public RayTracingRenderDebugCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
