
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficZebraController : TrafficLightController
	{
		public TrafficZebraController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
