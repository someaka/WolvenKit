
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SprintLowGravityEvents : LocomotionGroundEvents
	{
		public SprintLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
