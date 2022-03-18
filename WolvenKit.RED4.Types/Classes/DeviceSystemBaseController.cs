
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceSystemBaseController : MasterController
	{
		public DeviceSystemBaseController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
