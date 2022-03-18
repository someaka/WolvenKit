
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficLightController : ScriptableDeviceComponent
	{
		public TrafficLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
