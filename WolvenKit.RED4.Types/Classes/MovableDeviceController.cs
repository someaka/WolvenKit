
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableDeviceController : ScriptableDeviceComponent
	{
		public MovableDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
