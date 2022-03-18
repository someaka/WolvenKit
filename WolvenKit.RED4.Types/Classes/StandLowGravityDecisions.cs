
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StandLowGravityDecisions : LocomotionGroundDecisions
	{
		public StandLowGravityDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
