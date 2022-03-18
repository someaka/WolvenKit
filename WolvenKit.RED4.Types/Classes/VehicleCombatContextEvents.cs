
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleCombatContextEvents : InputContextTransitionEvents
	{
		public VehicleCombatContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
