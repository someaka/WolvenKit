
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrossingLightController : TrafficLightController
	{
		public CrossingLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
