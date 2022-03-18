
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InitialDecisions : LocomotionGroundDecisions
	{
		public InitialDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
