
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FallLowGravityDecisions : LocomotionAirLowGravityDecisions
	{
		public FallLowGravityDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
