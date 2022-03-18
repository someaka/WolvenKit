
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehiclePassengerContextEvents : InputContextTransitionEvents
	{
		public VehiclePassengerContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
