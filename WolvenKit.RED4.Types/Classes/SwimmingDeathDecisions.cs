
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingDeathDecisions : DeathDecisionsWithResurrection
	{
		public SwimmingDeathDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
