
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestructibleMasterLightController : DestructibleMasterDeviceController
	{
		public DestructibleMasterLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
