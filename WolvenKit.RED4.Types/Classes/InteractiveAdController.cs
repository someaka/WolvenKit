
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveAdController : ScriptableDeviceComponent
	{
		public InteractiveAdController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
