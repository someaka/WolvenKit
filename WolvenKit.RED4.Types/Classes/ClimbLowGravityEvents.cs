
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClimbLowGravityEvents : LocomotionGroundEvents
	{
		public ClimbLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
