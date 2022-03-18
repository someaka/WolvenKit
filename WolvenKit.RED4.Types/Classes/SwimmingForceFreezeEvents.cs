
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingForceFreezeEvents : LocomotionSwimmingEvents
	{
		public SwimmingForceFreezeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
