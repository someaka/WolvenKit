
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SurveillanceCameraController : SensorDeviceController
	{
		public SurveillanceCameraController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
