
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoverJumpDecisions : LocomotionAirDecisions
	{
		public HoverJumpDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
