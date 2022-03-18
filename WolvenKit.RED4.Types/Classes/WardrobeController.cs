
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WardrobeController : ScriptableDeviceComponent
	{
		public WardrobeController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
