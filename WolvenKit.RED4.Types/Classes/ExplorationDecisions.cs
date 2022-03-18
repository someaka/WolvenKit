
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplorationDecisions : HighLevelTransition
	{
		public ExplorationDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
