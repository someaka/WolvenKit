
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SurveillanceCameraStatus : BaseDeviceStatus
	{
		public SurveillanceCameraStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
