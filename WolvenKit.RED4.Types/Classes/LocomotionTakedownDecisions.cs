
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionTakedownDecisions : LocomotionTransition
	{
		public LocomotionTakedownDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
