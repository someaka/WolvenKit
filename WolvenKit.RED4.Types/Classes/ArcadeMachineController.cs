
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ArcadeMachineController : ScriptableDeviceComponent
	{
		public ArcadeMachineController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
