
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplorationEvents : HighLevelTransition
	{
		public ExplorationEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
