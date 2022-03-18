
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AirDeathDecisions : DeathDecisionsWithResurrection
	{
		public AirDeathDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
