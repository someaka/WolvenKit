
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathDecisions : HighLevelTransition
	{
		public DeathDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
