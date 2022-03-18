
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PickUpBodyAfterTakedownDecisions : LocomotionTakedownDecisions
	{
		public PickUpBodyAfterTakedownDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
