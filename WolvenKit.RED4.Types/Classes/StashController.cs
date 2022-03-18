
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StashController : ScriptableDeviceComponent
	{
		public StashController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
