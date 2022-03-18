
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceIdleEvents : LocomotionGroundEvents
	{
		public ForceIdleEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
