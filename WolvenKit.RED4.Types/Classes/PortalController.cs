
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PortalController : ScriptableDeviceComponent
	{
		public PortalController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
