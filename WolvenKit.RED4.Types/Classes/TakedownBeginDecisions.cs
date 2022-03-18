
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownBeginDecisions : LocomotionTakedownDecisions
	{
		public TakedownBeginDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
