
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorController : ScriptableDeviceComponent
	{
		public DoorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
