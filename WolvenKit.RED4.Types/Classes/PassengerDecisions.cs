
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassengerDecisions : VehicleTransition
	{
		public PassengerDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
