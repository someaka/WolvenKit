
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LadderEvents : LocomotionGroundEvents
	{
		public LadderEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
