
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorProximityDetectorController : ScriptableDeviceComponent
	{
		public DoorProximityDetectorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
