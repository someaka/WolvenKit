
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MediaDeviceController : ScriptableDeviceComponent
	{
		public MediaDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
