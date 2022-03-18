
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorStatus : BaseDeviceStatus
	{
		public DoorStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
