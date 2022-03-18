
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChestPressController : ScriptableDeviceComponent
	{
		public ChestPressController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
