
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FallDecisions : LocomotionAirDecisions
	{
		public FallDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
