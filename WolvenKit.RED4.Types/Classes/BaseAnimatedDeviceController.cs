
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseAnimatedDeviceController : ScriptableDeviceComponent
	{
		public BaseAnimatedDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
