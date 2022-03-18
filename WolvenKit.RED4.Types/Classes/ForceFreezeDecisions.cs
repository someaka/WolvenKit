
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceFreezeDecisions : LocomotionGroundDecisions
	{
		public ForceFreezeDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
