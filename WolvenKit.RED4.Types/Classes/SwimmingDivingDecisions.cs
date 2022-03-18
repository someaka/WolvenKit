
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingDivingDecisions : LocomotionSwimming
	{
		public SwimmingDivingDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
