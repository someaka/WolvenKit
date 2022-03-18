
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RayTracingCustomData : ICameraStorageCustomData
	{
		public RayTracingCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
