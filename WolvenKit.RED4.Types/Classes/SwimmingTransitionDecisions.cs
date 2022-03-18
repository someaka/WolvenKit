
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingTransitionDecisions : LocomotionSwimming
	{
		public SwimmingTransitionDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
