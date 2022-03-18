
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MediaDeviceStatus : BaseDeviceStatus
	{
		public MediaDeviceStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
