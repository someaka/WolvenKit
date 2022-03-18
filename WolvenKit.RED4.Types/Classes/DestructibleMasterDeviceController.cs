
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestructibleMasterDeviceController : MasterController
	{
		public DestructibleMasterDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
