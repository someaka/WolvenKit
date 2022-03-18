
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FridgeController : ScriptableDeviceComponent
	{
		public FridgeController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
