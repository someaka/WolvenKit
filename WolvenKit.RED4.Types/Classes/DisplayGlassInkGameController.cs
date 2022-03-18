
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisplayGlassInkGameController : DeviceInkGameControllerBase
	{
		public DisplayGlassInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
