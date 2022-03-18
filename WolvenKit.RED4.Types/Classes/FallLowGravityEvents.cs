
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FallLowGravityEvents : LocomotionAirLowGravityEvents
	{
		public FallLowGravityEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
