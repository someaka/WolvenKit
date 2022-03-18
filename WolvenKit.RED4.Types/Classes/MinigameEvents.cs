
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameEvents : HighLevelTransition
	{
		public MinigameEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
