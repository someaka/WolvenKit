
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VentilationEffectorController : ScriptableDeviceComponent
	{
		public VentilationEffectorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
