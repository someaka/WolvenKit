
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AlarmLightController : ScriptableDeviceComponent
	{
		public AlarmLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
