
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForkliftController : ScriptableDeviceComponent
	{
		public ForkliftController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
