
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JumpLowGravityDecisions : LocomotionAirLowGravityDecisions
	{
		public JumpLowGravityDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
