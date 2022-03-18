
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CoderController : ScriptableDeviceComponent
	{
		public CoderController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
