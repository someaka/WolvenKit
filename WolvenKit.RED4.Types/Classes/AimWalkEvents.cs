
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimWalkEvents : LocomotionGroundEvents
	{
		public AimWalkEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
