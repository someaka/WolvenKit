
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleHornOffDelayEvent : redEvent
	{
		public VehicleHornOffDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
