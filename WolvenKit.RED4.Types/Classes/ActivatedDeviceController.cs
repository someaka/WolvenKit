
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceController : ScriptableDeviceComponent
	{
		public ActivatedDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
