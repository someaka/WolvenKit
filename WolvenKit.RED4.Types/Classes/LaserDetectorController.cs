
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LaserDetectorController : ScriptableDeviceComponent
	{
		public LaserDetectorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
