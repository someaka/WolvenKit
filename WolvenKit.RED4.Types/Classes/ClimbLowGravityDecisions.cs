
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClimbLowGravityDecisions : LocomotionGroundDecisions
	{
		public ClimbLowGravityDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
