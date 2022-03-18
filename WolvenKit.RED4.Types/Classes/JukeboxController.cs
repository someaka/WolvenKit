
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JukeboxController : ScriptableDeviceComponent
	{
		public JukeboxController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
