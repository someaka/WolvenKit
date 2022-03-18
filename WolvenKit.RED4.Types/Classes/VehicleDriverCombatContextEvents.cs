
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDriverCombatContextEvents : InputContextTransitionEvents
	{
		public VehicleDriverCombatContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
