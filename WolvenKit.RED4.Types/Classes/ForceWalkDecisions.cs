
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceWalkDecisions : LocomotionGroundDecisions
	{
		public ForceWalkDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
