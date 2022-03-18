
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceNPCController : ScriptableDeviceComponent
	{
		public ActivatedDeviceNPCController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
