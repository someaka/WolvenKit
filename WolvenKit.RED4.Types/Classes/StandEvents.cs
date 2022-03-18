
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StandEvents : LocomotionGroundEvents
	{
		public StandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
