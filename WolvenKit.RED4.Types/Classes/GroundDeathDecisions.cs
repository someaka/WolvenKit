
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GroundDeathDecisions : DeathDecisionsWithResurrection
	{
		public GroundDeathDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
