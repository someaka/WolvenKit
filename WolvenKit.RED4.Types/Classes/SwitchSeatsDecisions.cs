
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwitchSeatsDecisions : VehicleTransition
	{
		public SwitchSeatsDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
