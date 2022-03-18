
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RoadBlockController : ScriptableDeviceComponent
	{
		public RoadBlockController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
