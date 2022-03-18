
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneExitingCombatDecisions : VehicleTransition
	{
		public SceneExitingCombatDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
