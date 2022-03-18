
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetrunnerControlPanelController : BasicDistractionDeviceController
	{
		public NetrunnerControlPanelController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
