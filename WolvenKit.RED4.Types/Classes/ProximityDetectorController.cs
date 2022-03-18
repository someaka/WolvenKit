
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProximityDetectorController : ScriptableDeviceComponent
	{
		public ProximityDetectorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
