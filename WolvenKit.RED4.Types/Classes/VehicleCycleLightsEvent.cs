
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleCycleLightsEvent : redEvent
	{
		public VehicleCycleLightsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
