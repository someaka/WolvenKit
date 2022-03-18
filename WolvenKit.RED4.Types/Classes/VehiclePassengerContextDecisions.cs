
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehiclePassengerContextDecisions : VehicleGameplayContextDecisions
	{
		public VehiclePassengerContextDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
