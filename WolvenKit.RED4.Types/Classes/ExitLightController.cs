
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExitLightController : ScriptableDeviceComponent
	{
		public ExitLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
