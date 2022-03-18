
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElectricLightController : ScriptableDeviceComponent
	{
		public ElectricLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
