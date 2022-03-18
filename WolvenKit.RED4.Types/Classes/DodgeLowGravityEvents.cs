
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DodgeLowGravityEvents : LocomotionGroundEvents
	{
		public DodgeLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
