
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlideFallDecisions : LocomotionAirDecisions
	{
		public SlideFallDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
