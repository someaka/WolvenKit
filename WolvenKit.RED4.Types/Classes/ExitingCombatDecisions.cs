
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExitingCombatDecisions : VehicleTransition
	{
		public ExitingCombatDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
