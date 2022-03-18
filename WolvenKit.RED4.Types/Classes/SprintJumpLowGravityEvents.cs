
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SprintJumpLowGravityEvents : LocomotionAirLowGravityEvents
	{
		public SprintJumpLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
