
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameDecisions : HighLevelTransition
	{
		public MinigameDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
