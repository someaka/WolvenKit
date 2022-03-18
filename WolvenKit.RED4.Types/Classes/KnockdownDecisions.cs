
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KnockdownDecisions : StatusEffectDecisions
	{
		public KnockdownDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
