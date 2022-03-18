
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForcedKnockdownDecisions : KnockdownDecisions
	{
		public ForcedKnockdownDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
