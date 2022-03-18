
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownGrappleFailedEvents : LocomotionTakedownEvents
	{
		public TakedownGrappleFailedEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
