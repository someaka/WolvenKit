
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownEndDecisions : LocomotionTakedownDecisions
	{
		public TakedownEndDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
