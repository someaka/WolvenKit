
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DodgeAirLowGravityEvents : LocomotionAirLowGravityEvents
	{
		public DodgeAirLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
