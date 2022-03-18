
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnteringCombatDecisions : VehicleTransition
	{
		public EnteringCombatDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
