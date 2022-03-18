
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StandLowGravityEvents : LocomotionGroundEvents
	{
		public StandLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
