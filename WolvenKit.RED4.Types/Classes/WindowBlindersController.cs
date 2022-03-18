
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindowBlindersController : ScriptableDeviceComponent
	{
		public WindowBlindersController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
