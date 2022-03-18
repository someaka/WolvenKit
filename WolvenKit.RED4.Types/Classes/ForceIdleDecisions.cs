
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceIdleDecisions : LocomotionGroundDecisions
	{
		public ForceIdleDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
