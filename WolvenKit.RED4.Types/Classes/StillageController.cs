
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StillageController : ScriptableDeviceComponent
	{
		public StillageController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
