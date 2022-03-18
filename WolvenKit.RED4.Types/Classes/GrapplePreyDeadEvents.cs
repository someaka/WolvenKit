
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrapplePreyDeadEvents : LocomotionTakedownEvents
	{
		public GrapplePreyDeadEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
