
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreCrouchLowGravityEvents : LocomotionGroundEvents
	{
		public PreCrouchLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
