
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionGroundEvents : LocomotionEventsTransition
	{
		public LocomotionGroundEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
