
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathLandDecisions : FailedLandingAbstractDecisions
	{
		public DeathLandDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
