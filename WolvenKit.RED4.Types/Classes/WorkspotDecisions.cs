
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorkspotDecisions : LocomotionGroundDecisions
	{
		public WorkspotDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
