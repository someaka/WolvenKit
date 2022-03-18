
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LadderDecisions : LocomotionGroundDecisions
	{
		public LadderDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
