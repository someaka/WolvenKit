
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GlitchedTurretController : ScriptableDeviceComponent
	{
		public GlitchedTurretController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
