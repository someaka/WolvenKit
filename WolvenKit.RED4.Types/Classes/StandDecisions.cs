
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StandDecisions : LocomotionGroundDecisions
	{
		public StandDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
