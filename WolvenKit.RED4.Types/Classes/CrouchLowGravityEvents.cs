
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrouchLowGravityEvents : LocomotionGroundEvents
	{
		public CrouchLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
