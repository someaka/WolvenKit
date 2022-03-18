
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AbstractLandDecisions : LocomotionGroundDecisions
	{
		public AbstractLandDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
