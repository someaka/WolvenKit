
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MasterController : ScriptableDeviceComponent
	{
		public MasterController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
